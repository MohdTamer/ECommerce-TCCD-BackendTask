using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CartItemService : ICartItemService
    {
        private readonly ICartItemRepository _repository;
        public CartItemService(ICartItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<CartItem> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task AddAsync(CartItemDto dto)
        {
            var item = new CartItem
            {
                ProductId = dto.ProductId,
                CartId = dto.CartId,
                UnitPrice = dto.UnitPrice,
                Quantity = dto.Quantity
            };
            await _repository.AddAsync(item);
        }

        public async Task<CartItem> UpdateAsync(int id, CartItemDto dto)
        {
            var item = await _repository.GetAsync(id);

            item.ProductId = dto.ProductId;
            item.CartId = dto.CartId;
            item.UnitPrice = dto.UnitPrice;
            item.Quantity = dto.Quantity;

            return await _repository.UpdateAsync(item);
        }
    }
}
