using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TemplateFramework.Application.DTOs.Products;
using TemplateFramework.Application.Responses;
using TemplateFramework.Domain.Interfaces;

namespace TemplateFramework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsProcedureController : ControllerBase
    {
        private readonly ICallProcedureProduct _callProcedure;
        public ProductsProcedureController(ICallProcedureProduct callProcedure)
        {
            _callProcedure = callProcedure;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAll()
        {
            var products = await _callProcedure.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponse>> GetById(int id)
        {

            var product = await _callProcedure.GetByIdAsync(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponse>> Create([FromBody] CreateProductDto createDto)
        {
            var created = await _callProcedure.CreateAsync(createDto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateProductDto updateDto)
        {

            var updated = await _callProcedure.UpdateAsync(id, updateDto);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            
           await _callProcedure.DeleteAsync(id);
           return NoContent();
            
        }
    }
}
