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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Category> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task AddAsync(CategoryDto dto)
        {
            var category = new Category
            {
                Name = dto.Name
            };
            await _repository.AddAsync(category);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Category> UpdateAsync(int id, CategoryDto dto)
        {
            var category = await _repository.GetAsync(id);

            category.Name = dto.Name;

            return await _repository.UpdateAsync(category);
        }
    }
}
