using Microsoft.EntityFrameworkCore;
using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;
using TemplateFramework.Infastructure.Data;

namespace TemplateFramework.Infastructure.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(TemplateDbContext context) : base(context)
        {
        }
        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task<bool> IsEmailTakenAsync(string email)
        {
            return await _dbSet.AnyAsync(u => u.Email == email);
        }

        public async Task<bool> IsUsernameTakenAsync(string username)
        {
            return await _dbSet.AnyAsync(u => u.Username == username);
        }
        public async Task<User> GetCheckout(int id)
        {
            return await _dbSet.Include(u => u.RefreshTokens).OrderByDescending(rt => rt.CreatedAt)
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
