using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace ECommerceTCCD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service) 
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get() 
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            return await _service.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductsDto dto)
        {
            await _service.AddAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            if(result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductsDto>> Update(int id, ProductsDto dto)
        {
            var product = await _service.UpdateAsync(id, dto);
            if (product == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
