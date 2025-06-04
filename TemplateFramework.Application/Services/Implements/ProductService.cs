using AutoMapper;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;
using TemplateFramework.Application.Services.Interfaces;
using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;

namespace TemplateFramework.Application.Services.Implements
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductResponse> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) throw new KeyNotFoundException("Product not found");

            return _mapper.Map<ProductResponse>(product);
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
    }
}
