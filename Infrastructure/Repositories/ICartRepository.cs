using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ICartRepository
    {
        Task<Cart> GetAsync(int id);
        Task AddAsync(Cart cart);
        Task<bool> DeleteAsync(int id);
    }
}
