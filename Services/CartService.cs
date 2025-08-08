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
    public class CartService : ICartService
    {
        private readonly ICartRepository _repository;
        public CartService(ICartRepository repository)
        {
            _repository = repository;
        }

        public async Task<Cart> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task AddAsync(CartDto dto)
        {
            var cart = new Cart
            {
                Status = dto.Status
            };
            await _repository.AddAsync(cart);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
