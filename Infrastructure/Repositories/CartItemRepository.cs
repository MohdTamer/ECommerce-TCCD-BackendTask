using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly AppDbContext _context;
        public CartItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CartItem> GetAsync(int id)
        {
            return await _context.CartItem.FirstOrDefaultAsync(ci => ci.Id == id);
        }

        public async Task AddAsync(CartItem item)
        {
            await _context.CartItem.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task<CartItem> UpdateAsync(CartItem item)
        {
            _context.CartItem.Update(item);
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
