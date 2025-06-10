using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;
using TemplateFramework.Domain.Page;

namespace TemplateFramework.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductResponse> GetByIdAsync(int id);
        Task<IEnumerable<ProductResponse>> GetAllAsync();
        Task<ProductResponse> CreateAsync(CreateProductDto createProductDto);
        Task<ProductResponse> UpdateAsync(int id, UpdateProductDto updateProductDto);
        Task DeleteAsync(int id);
        Task<PagedResult<ProductResponse>> GetPagedProductsAsync(int pageNumber, int pageSize);
        Task<PagedResult<ProductResponse>> GetPagedProductsDapperAsync(int pageNumber, int pageSize, string oderbyColum);
    }
}
