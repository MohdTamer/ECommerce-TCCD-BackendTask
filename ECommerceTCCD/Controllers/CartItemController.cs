using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceTCCD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartItemController : ControllerBase
    {
        private readonly ICartItemService _service;
        public CartItemController(ICartItemService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CartItem>> GetById(int id)
        {
            return await _service.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CartItemDto dto)
        {
            await _service.AddAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CartItemDto>> Update(int id, CartItemDto dto)
        {
            var item = await _service.UpdateAsync(id, dto);
            if (item == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
