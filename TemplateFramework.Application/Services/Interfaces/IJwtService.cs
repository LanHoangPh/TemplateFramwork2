using System.Security.Claims;


namespace TemplateFramework.Application.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateAccessToken(int userId, string email, string username);
        string GenerateRefreshToken();
        ClaimsPrincipal? ValidateToken(string token);
        DateTime GetTokenExpiration(string token);
    }
}
