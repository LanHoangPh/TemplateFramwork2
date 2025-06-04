using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateFramework.Domain.Entities;

namespace TemplateFramework.Domain.Interfaces
{
    public interface IRefreshTokenRepository : IGenericRepository<RefreshToken>
    {
        Task<RefreshToken> GetByTokenAsync(string token);
        Task<IEnumerable<RefreshToken>> GetUserTokensAsync(int userId);
        Task RevokeAllUserTokensAsync(int userId);
    }
}
