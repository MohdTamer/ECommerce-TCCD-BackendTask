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
    public class CartRepository : ICartRepository
    {
        private readonly AppDbContext _context;
        public CartRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cart> GetAsync(int id)
        {
            return await _context.Cart.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(Cart cart)
        {
            await _context.Cart.AddAsync(cart);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cart = await _context.Cart.FirstOrDefaultAsync(c => c.Id == id);
            if (cart == null)
            {
                return false;
            }
            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
