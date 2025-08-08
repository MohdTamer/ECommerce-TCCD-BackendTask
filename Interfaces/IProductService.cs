using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetAsync(int id);
        Task AddAsync(ProductsDto dto);
        Task<bool> DeleteAsync(int id);
        Task<Product> UpdateAsync(int id, ProductsDto dto);
    }
}
