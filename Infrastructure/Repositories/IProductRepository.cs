using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetAsync(int id);
        Task AddAsync(Product product);
        Task<bool> DeleteAsync(int id);
        Task<Product> UpdateAsync(Product product);
    }
}
