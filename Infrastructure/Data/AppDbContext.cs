using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Category => Set<Category>();
        public DbSet<Cart> Cart => Set<Cart>();
        public DbSet<CartItem> CartItem => Set<CartItem>();
    }
}
