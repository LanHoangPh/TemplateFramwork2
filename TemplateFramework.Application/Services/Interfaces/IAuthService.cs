using TemplateFramework.Application.DTOs.Auth;
using TemplateFramework.Application.Responses;

namespace TemplateFramework.Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponse> RegisterAsync(RegisterUserDto registerDto);
        Task<AuthResponse> LoginAsync(LoginDto loginDto);
        Task<AuthResponse> RefreshTokenAsync(string refreshToken);
        Task<bool> RevokeTokenAsync(string refreshToken);
        Task LogoutAsync(int userId);
    }
}
