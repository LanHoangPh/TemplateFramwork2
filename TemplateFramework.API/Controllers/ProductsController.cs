using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Services.Interfaces;

namespace TemplateFramework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _callProcedure;
        private readonly ILogger<ProductsController> _logger;
        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _callProcedure = productService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Fetching all products get:api/products");
            try
            {
                var products = await _callProcedure.GetAllAsync();
                return Ok(products);
            }
            catch
            {
                _logger.LogError("An error occurred while fetching all products get:api/products.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _callProcedure.GetByIdAsync(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto createProductDto)
        {
            var product = await _callProcedure.CreateAsync(createProductDto);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductDto updateProductDto)
        {
            var product = await _callProcedure.UpdateAsync(id, updateProductDto);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _callProcedure.DeleteAsync(id);
            return NoContent();
        }
    }
}
