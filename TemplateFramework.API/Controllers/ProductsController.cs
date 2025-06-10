using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;
using TemplateFramework.Application.Services.Implements;
using TemplateFramework.Application.Services.Interfaces;
using TemplateFramework.Domain.Page;

namespace TemplateFramework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableRateLimiting("sliding")]
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
        [ProducesResponseType(typeof(PagedResult<ProductResponse>), 200)] 
        public async Task<ActionResult<PagedResult<ProductResponse>>> GetAllAsync([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100)
        {
            if (pageNumber < 1 || pageSize < 1)
            {
                return BadRequest("Page number and page size must be greater than 0.");
            }
            var result = await _callProcedure.GetPagedProductsAsync(pageNumber, pageSize);
            return Ok(result);
        }
        [HttpGet("Dapper")]
        [ProducesResponseType(typeof(PagedResult<ProductResponse>), 200)]
        public async Task<ActionResult<PagedResult<ProductResponse>>> GetAllAsyncDapper([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100, [FromQuery] string? oderbyColum = null)
        {
            if (pageNumber < 1 || pageSize < 1)
            {
                return BadRequest("Page number and page size must be greater than 0.");
            }
            if(string.IsNullOrWhiteSpace(oderbyColum))
            {
                oderbyColum = "Id";
            }
            var result = await _callProcedure.GetPagedProductsDapperAsync(pageNumber, pageSize, oderbyColum);
            return Ok(result);
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    _logger.LogInformation("Fetching all products get:api/products");
        //    try
        //    {
        //        var products = await _callProcedure.GetAllAsync();
        //        return Ok(products);
        //    }
        //    catch
        //    {
        //        _logger.LogError("An error occurred while fetching all products get:api/products.");
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
        //    }
        //}

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
