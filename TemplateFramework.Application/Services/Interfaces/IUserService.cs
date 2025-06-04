using TemplateFramework.Application.DTOs.Auth;
using TemplateFramework.Application.Responses;

namespace TemplateFramework.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserResponse> GetByIdAsync(int id);
        Task<UserResponse> GetByEmailAsync(string email);
        Task<IEnumerable<UserResponse>> GetAllAsync();
        Task<bool> UpdateUserAsync(int id, UpdateUserDto updateDto);
        Task<bool> DeleteUserAsync(int id);
    }
}
