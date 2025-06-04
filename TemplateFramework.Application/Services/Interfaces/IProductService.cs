using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;

namespace TemplateFramework.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductResponse> GetByIdAsync(int id);
        Task<IEnumerable<ProductResponse>> GetAllAsync();
        Task<ProductResponse> CreateAsync(CreateProductDto createProductDto);
        Task<ProductResponse> UpdateAsync(int id, UpdateProductDto updateProductDto);
        Task DeleteAsync(int id);
    }
}
