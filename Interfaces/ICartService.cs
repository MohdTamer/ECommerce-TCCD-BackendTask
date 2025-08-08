using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICartService
    {
        Task<Cart> GetAsync(int id);
        Task AddAsync(CartDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
