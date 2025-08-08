using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface ICartItemRepository
    {
        Task<CartItem> GetAsync(int id);
        Task AddAsync(CartItem item);
        Task<CartItem> UpdateAsync(CartItem item);
    }
}
