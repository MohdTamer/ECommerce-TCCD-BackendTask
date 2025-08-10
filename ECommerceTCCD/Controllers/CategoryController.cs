using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceTCCD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            return await _service.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryDto dto)
        {
            await _service.AddAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            if (result)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryDto>> Update(int id, CategoryDto dto)
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
