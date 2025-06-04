using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateFramework.Domain.Entities;

namespace TemplateFramework.Domain.Interfaces
{
    public interface ICallProcedureProductRepo
    {
        Task<IEnumerable<Products>> GetAllAsync();
        Task<Products> GetByIdAsync(int id);
        Task<Products> CreateAsync(Products products);
        Task  UpdateAsync(int id, Products products);
        Task DeleteAsync(int id);
    }
}
