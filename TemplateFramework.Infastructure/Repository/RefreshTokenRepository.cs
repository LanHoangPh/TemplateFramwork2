using Microsoft.EntityFrameworkCore;
using System.Data;
using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;
using TemplateFramework.Infastructure.Data;

namespace TemplateFramework.Infastructure.Repository
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(TemplateDbContext context) : base(context)
        {
        }

        public async Task<RefreshToken> GetByTokenAsync(string token)
        {
            return await _dbSet.Include(rt => rt.User)
                              .FirstOrDefaultAsync(rt => rt.Token == token);
        }

        public async Task<IEnumerable<RefreshToken>> GetUserTokensAsync(int userId)
        {
            return await _dbSet.Where(rt => rt.UserId == userId).ToListAsync();
        }

        public async Task RevokeAllUserTokensAsync(int userId)
        {
            var tokens = await _dbSet.Where(rt => rt.UserId == userId && !rt.IsRevoked).ToListAsync();

            foreach (var token in tokens)
            {
                token.IsRevoked = true;
            }

            await _context.SaveChangesAsync();
        }
    }
}
