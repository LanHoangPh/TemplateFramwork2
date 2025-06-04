using AutoMapper;
using TemplateFramework.Application.DTOs.Auth;
using TemplateFramework.Application.Responses;
using TemplateFramework.Application.Services.Interfaces;
using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;

namespace TemplateFramework.Application.Services.Implements
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IRefreshTokenRepository _refreshTokenRepository;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;

        public AuthService(
            IUserRepository userRepository,
            IRefreshTokenRepository refreshTokenRepository,
            IJwtService jwtService,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _refreshTokenRepository = refreshTokenRepository;
            _jwtService = jwtService;
            _mapper = mapper;
        }
        public async Task<AuthResponse> LoginAsync(LoginDto loginDto)
        {
            var user = await _userRepository.GetByEmailAsync(loginDto.EmailOrUsername) ??
                   await _userRepository.GetByUsernameAsync(loginDto.EmailOrUsername);

            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
            {
                throw new UnauthorizedAccessException("Invalid credentials");
            }

            if (!user.IsActive)
            {
                throw new UnauthorizedAccessException("Account is deactivated");
            }

            var accessToken = _jwtService.GenerateAccessToken(user.Id, user.Email, user.Username);
            var refreshToken = _jwtService.GenerateRefreshToken();

            await _refreshTokenRepository.AddAsync(new RefreshToken
            {
                Token = refreshToken,
                UserId = user.Id,
                ExpiresAt = DateTime.UtcNow.AddDays(7),
                CreatedAt = DateTime.UtcNow
            });

            return new AuthResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiresAt = _jwtService.GetTokenExpiration(accessToken),
                User = _mapper.Map<UserResponse>(user)
            };
        }

        public async Task LogoutAsync(int userId)
        {
            await _refreshTokenRepository.RevokeAllUserTokensAsync(userId);
        }

        public async Task<AuthResponse> RefreshTokenAsync(string refreshToken)
        {
            var token = await _refreshTokenRepository.GetByTokenAsync(refreshToken);

            if (token == null || token.IsRevoked || token.ExpiresAt <= DateTime.UtcNow)
            {
                throw new UnauthorizedAccessException("Invalid");
            }

            token.IsRevoked = true;
            await _refreshTokenRepository.UpdateAsync(token);

            var accessToken = _jwtService.GenerateAccessToken(token.User.Id, token.User.Email, token.User.Username);
            var newRefreshToken = _jwtService.GenerateRefreshToken();

            await _refreshTokenRepository.AddAsync(new RefreshToken
            {
                Token = newRefreshToken,
                UserId = token.UserId,
                ExpiresAt = DateTime.UtcNow.AddDays(7),
                CreatedAt = DateTime.UtcNow
            });

            return new AuthResponse
            {
                AccessToken = accessToken,
                RefreshToken = newRefreshToken,
                ExpiresAt = _jwtService.GetTokenExpiration(accessToken),
                User = _mapper.Map<UserResponse>(token.User)
            };
        }

        public async Task<AuthResponse> RegisterAsync(RegisterUserDto registerDto)
        {
            if (await _userRepository.IsEmailTakenAsync(registerDto.Email))
            {
                throw new ArgumentException("Email is already registered");
            }

            if (await _userRepository.IsUsernameTakenAsync(registerDto.Username))
            {
                throw new ArgumentException("Username is already taken");
            }

            var user = new User
            {
                Username = registerDto.Username,
                Email = registerDto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password),
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                CreatedAt = DateTime.UtcNow
            };

            await _userRepository.AddAsync(user);

            var accessToken = _jwtService.GenerateAccessToken(user.Id, user.Email, user.Username);
            var refreshToken = _jwtService.GenerateRefreshToken();

            await _refreshTokenRepository.AddAsync(new RefreshToken
            {
                Token = refreshToken,
                UserId = user.Id,
                ExpiresAt = DateTime.UtcNow.AddDays(7), // 7 days
                CreatedAt = DateTime.UtcNow
            });

            return new AuthResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiresAt = _jwtService.GetTokenExpiration(accessToken),
                User = _mapper.Map<UserResponse>(user)
            };
        }

        public async Task<bool> RevokeTokenAsync(string refreshToken)
        {
            var token = await _refreshTokenRepository.GetByTokenAsync(refreshToken);

            if (token == null)
            {
                return false;
            }

            token.IsRevoked = true;
            await _refreshTokenRepository.UpdateAsync(token);
            return true;
        }
    }
}
