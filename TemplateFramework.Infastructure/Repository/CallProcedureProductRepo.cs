using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;
using TemplateFramework.Infastructure.Data;

namespace TemplateFramework.Infastructure.Repository
{
    public class CallProcedureProductRepo : ICallProcedureProductRepo
    {
        private readonly TemplateDbContext _dbContext;
        public CallProcedureProductRepo(TemplateDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Products> CreateAsync(Products product)
        {
            var pName = new MySqlParameter("p_Name", product.Name);
            var pDesc = new MySqlParameter("p_Description", product.Description);
            var pPrice = new MySqlParameter("p_Price", product.Price);
            var result = await _dbContext.Products
            .FromSqlRaw("CALL CreateProduct2(@p_Name, @p_Description, @p_Price)", pName, pDesc, pPrice).ToListAsync();

            if (result.Any())
            {
                return result.FirstOrDefault();
            }

            return product;
        }

        public async Task DeleteAsync(int id)
        {
            var pId = new MySqlParameter("p_Id", id);

            var result = await _dbContext.Database.ExecuteSqlRawAsync(
                "CALL DeleteProduct(@p_Id)", pId);

        }

        public async Task<IEnumerable<Products>> GetAllAsync()
        {
            return await _dbContext.Products
            .FromSqlRaw("CALL GetAllProducts()")
            .ToListAsync();
        }

        public async Task<Products> GetByIdAsync(int id)
        {
            var param = new MySqlParameter("p_Id", id);

            var result = await _dbContext.Products
                .FromSqlRaw("CALL GetProductById(@p_Id)", param)
                .ToListAsync();

            return result.FirstOrDefault();
        }

        public async Task UpdateAsync(int id, Products products)
        {
            var pId = new MySqlParameter("p_Id", id);
            var pName = new MySqlParameter("p_Name", products.Name);
            var pDesc = new MySqlParameter("p_Description", products.Description);
            var pPrice = new MySqlParameter("p_Price", products.Price);

            var result = await _dbContext.Database.ExecuteSqlRawAsync(
                "CALL UpdateProduct(@p_Id, @p_Name, @p_Description, @p_Price)",
                pId, pName, pDesc, pPrice);

            if (result == 0)
            {
                throw new KeyNotFoundException("Product not found or not updated");
            }

        }
    }
}
