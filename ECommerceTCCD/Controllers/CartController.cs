using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceTCCD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _service;
        public CartController(ICartService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cart>> GetById(int id)
        {
            return await _service.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CartDto dto)
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
    }
}
