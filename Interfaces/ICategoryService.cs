using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetAsync(int id);
        Task AddAsync(CategoryDto dto);
        Task<bool> DeleteAsync(int id);
        Task<Category> UpdateAsync(int id, CategoryDto dto);
    }
}
