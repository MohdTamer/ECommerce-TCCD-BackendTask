using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetAsync(int id);
        Task AddAsync(Category category);
        Task<bool> DeleteAsync(int id);
        Task<Category> UpdateAsync(Category category);
    }
}
