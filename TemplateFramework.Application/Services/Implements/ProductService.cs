using AutoMapper;
using Microsoft.Extensions.Logging;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;
using TemplateFramework.Application.Services.Interfaces;
using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;
using TemplateFramework.Domain.Page;

namespace TemplateFramework.Application.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, IMapper mapper, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProductResponse> GetByIdAsync(int id)
        {
            try
            {
                _logger.LogInformation("Start mapper product with ID: {Id}", id);
                var product = await _productRepository.GetByIdAsync(id);
                if (product == null) throw new KeyNotFoundException("Product not found");

                return _mapper.Map<ProductResponse>(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting product by ID: {Id}", id);
                throw;
            }
        }

        public async Task<IEnumerable<ProductResponse>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductResponse>>(products);
        }

        public async Task<ProductResponse> CreateAsync(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Products>(createProductDto);
            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;

            await _productRepository.AddAsync(product);
            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<ProductResponse> UpdateAsync(int id, UpdateProductDto updateProductDto)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) throw new KeyNotFoundException("Product not found");

            _mapper.Map(updateProductDto, product);
            product.UpdatedAt = DateTime.UtcNow;

            await _productRepository.UpdateAsync(product);
            return _mapper.Map<ProductResponse>(product);
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) throw new KeyNotFoundException("Product not found");

            await _productRepository.DeleteAsync(product);
        }

        public async Task<PagedResult<ProductResponse>> GetPagedProductsAsync(int pageNumber, int pageSize)
        {
            var pagedProducts = await _productRepository.GetPagedEFcoreAsync(pageNumber, pageSize, null);

            var productResponses = _mapper.Map<IEnumerable<ProductResponse>>(pagedProducts.Items);

            return new PagedResult<ProductResponse>
            {
                Items = productResponses,
                PageNumber = pagedProducts.PageNumber,
                PageSize = pagedProducts.PageSize,
                TotalRecords = pagedProducts.TotalRecords
            };
        }

        public async Task<PagedResult<ProductResponse>> GetPagedProductsDapperAsync(int pageNumber, int pageSize, string oderbyColum)
        {
            var pagedProducts = await _productRepository.GetPagedDapperAsync(pageNumber, pageSize, oderbyColum, true);

            var productResponses = _mapper.Map<IEnumerable<ProductResponse>>(pagedProducts.Items);

            return new PagedResult<ProductResponse>
            {
                Items = productResponses,
                PageNumber = pagedProducts.PageNumber,
                PageSize = pagedProducts.PageSize,
                TotalRecords = pagedProducts.TotalRecords
            };
        }
    }
}
