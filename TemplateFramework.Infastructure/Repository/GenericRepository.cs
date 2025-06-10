using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;
using TemplateFramework.Domain.Interfaces;
using TemplateFramework.Domain.Page;
using TemplateFramework.Infastructure.Data;

namespace TemplateFramework.Infastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TemplateDbContext _context;
        protected readonly DbSet<T> _dbSet;
        private readonly IDbConnection _dbConnection;
        private readonly string _tableName;

        public GenericRepository(TemplateDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _dbConnection = _context.Database.GetDbConnection();
            _tableName = context.Model.FindEntityType(typeof(T))?.GetTableName()
                         ?? throw new InvalidOperationException($"Table name for entity type {typeof(T).Name} could not be determined.");
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                var query = $"SELECT * FROM {_tableName} WHERE Id = @pId"; // query
                var entities = await _dbConnection.QuerySingleOrDefaultAsync<T>(query, new { pId = id }); // ORM wwith dapperr
                return entities!;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving entity by ID {id}: {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbConnection.QueryAsync<T>($"SELECT * FROM {_tableName}");
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<T> FindFirstAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<PagedResult<T>> GetPagedEFcoreAsync(int pageNumber, int pageSize, Expression<Func<T, bool>>? predicate = null)
        {
            var query = _dbSet.AsNoTracking();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            var primaryKeyName = _context.Model.FindEntityType(typeof(T))!.FindPrimaryKey()!.Properties.First().Name;

            var totalRecords = await query.CountAsync();
            var items = await query.OrderBy(e => EF.Property<object>(e, "Id"))
                                   .Skip((pageNumber - 1) * pageSize)
                                   .Take(pageSize)
                                   .ToListAsync();

            return new PagedResult<T>
            {
                Items = items,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalRecords
            };
        }

        public async Task<PagedResult<T>> GetPagedDapperAsync(int pageNumber, int pageSize, string? oderbyColum, bool ascending = true)
        {
            var primaryKeyName = _context.Model.FindEntityType(typeof(T))!.FindPrimaryKey()!.Properties.First().Name;

            oderbyColum ??= primaryKeyName; // nếu oderbyColum null thì sử dụng khóa chính

            var validColumns = _context.Model.FindEntityType(typeof(T))!
            .GetProperties().Select(p => p.Name).ToList();

            if (!validColumns.Contains(oderbyColum, StringComparer.OrdinalIgnoreCase))
            {
                throw new ArgumentException($"Invalid column name for ordering: {oderbyColum}");
            }

            var sortDirection = ascending ? "ASC" : "DESC";

            var offset = (pageNumber - 1) * pageSize;

            var sql = $@"
                SELECT COUNT(*) FROM `{_tableName}`;
                SELECT * FROM `{_tableName}` 
                ORDER BY `{oderbyColum}` {sortDirection}
                LIMIT @PageSize OFFSET @Offset;";

            using (var multi = await _dbConnection.QueryMultipleAsync(sql, new { PageSize = pageSize, Offset = offset }))
            {
                var totalRecords = await multi.ReadFirstAsync<int>();
                var items = await multi.ReadAsync<T>();

                return new PagedResult<T>
                {
                    Items = items,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalRecords = totalRecords
                };
            }
        }
    }
}
