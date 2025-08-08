using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Product> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task AddAsync(ProductsDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                ImageUrl = dto.ImageUrl,
                Stock = dto.Stock,
                Price = dto.Price,
                Description = dto.Description,
                CategoryId = dto.CategoryId
            };
            await _repository.AddAsync(product);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Product> UpdateAsync(int id, ProductsDto dto)
        {
            var product = await _repository.GetAsync(id);

            product.Name = dto.Name;
            product.ImageUrl = dto.ImageUrl;
            product.Stock = dto.Stock;
            product.Price = dto.Price;
            product.Description = dto.Description;
            product.CategoryId = dto.CategoryId;

            return await _repository.UpdateAsync(product);
        }
    }
}
