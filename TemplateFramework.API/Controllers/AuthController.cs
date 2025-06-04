using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TemplateFramework.Application.DTOs.Auth;
using TemplateFramework.Application.Responses;
using TemplateFramework.Application.Services.Interfaces;

namespace TemplateFramework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthResponse>> Register([FromBody] RegisterUserDto registerDto)
        {
            var result = await _authService.RegisterAsync(registerDto);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] LoginDto loginDto)
        {
            var result = await _authService.LoginAsync(loginDto);
            return Ok(result);
        }

        [HttpPost("refresh")]
        public async Task<ActionResult<AuthResponse>> RefreshToken([FromBody] RefreshTokenDto refreshTokenDto)
        {
            var result = await _authService.RefreshTokenAsync(refreshTokenDto.RefreshToken);
            return Ok(result);
        }

        [HttpPost("revoke")]
        [Authorize]
        public async Task<ActionResult> RevokeToken([FromBody] RefreshTokenDto refreshTokenDto)
        {
            var result = await _authService.RevokeTokenAsync(refreshTokenDto.RefreshToken);

            if (!result)
            {
                return BadRequest(new { message = "Token not found" });
            }

            return Ok(new { message = "Token revoked successfully" });
        }

        [HttpPost("logout")]
        [Authorize]
        public async Task<ActionResult> Logout()
        {
            await _authService.LogoutAsync(GetCurrentUserId());
            return Ok(new { message = "Logged out successfully" });
        }
        private int GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            return userIdClaim != null ? int.Parse(userIdClaim.Value) : 0;
        }
    }
}
