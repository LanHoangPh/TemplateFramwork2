using AutoMapper;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;
using TemplateFramework.Domain.Entities;
using TemplateFramework.Domain.Interfaces;

namespace TemplateFramework.Application.Services.Implements
{
    public class CallProcedureProduct : ICallProcedureProduct
    {
        private readonly IMapper _mapper;
        private readonly ICallProcedureProductRepo _repo;
        public CallProcedureProduct(IMapper mapper, ICallProcedureProductRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<ProductResponse> CreateAsync(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Products>(createProductDto);
            var result = await _repo.CreateAsync(product);
            return _mapper.Map<ProductResponse>(result);
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                await _repo.DeleteAsync(id);
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Product deletiing exis");
            }

        }

        public async Task<IEnumerable<ProductResponse>> GetAllAsync()
        {
            var products = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductResponse>>(products);
        }

        public async Task<ProductResponse> GetByIdAsync(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null)
                throw new KeyNotFoundException("Product not found");

            return _mapper.Map<ProductResponse>(product);
        }

        public async Task<ProductResponse> UpdateAsync(int id, UpdateProductDto updateProductDto)
        {
            var product = _mapper.Map<Products>(updateProductDto);
            await _repo.UpdateAsync(id, product);
            var updated = await _repo.GetByIdAsync(id);
            return _mapper.Map<ProductResponse>(updated);
        }
    }
}
