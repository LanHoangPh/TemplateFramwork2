using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;

namespace TemplateFramework.Domain.Interfaces
{
    public interface ICallProcedureProduct
    {
        Task<IEnumerable<ProductResponse>> GetAllAsync();
        Task<ProductResponse> GetByIdAsync(int id);
        Task<ProductResponse> CreateAsync(CreateProductDto createProductDto);
        Task<ProductResponse> UpdateAsync(int id, UpdateProductDto updateProductDto);
        Task  DeleteAsync(int id);
    }
}
