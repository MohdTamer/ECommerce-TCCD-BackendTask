using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICartItemService
    {
        Task<CartItem> GetAsync(int id);
        Task AddAsync(CartItemDto dto);
        Task<CartItem> UpdateAsync(int id, CartItemDto dto);
    }
}
