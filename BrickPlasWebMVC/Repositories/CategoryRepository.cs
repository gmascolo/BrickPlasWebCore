using BrickPlasWebMVC.Data;
using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Services;
using Microsoft.EntityFrameworkCore;

namespace BrickPlasWebMVC.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        Task<bool> IGenericRepository<Category>.Create(Category entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Category>.Delete(int? id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Category>.DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        async Task<List<Category>> IGenericRepository<Category>.GetAll()
        {
            List<Category> categories = await _context.Categories.ToListAsync();

            return categories;
        }

        Task<Category> IGenericRepository<Category>.GetById(int? id)
        {
            throw new NotImplementedException();
        }

        Task<Category> ICategoryRepository.GetCategoryByName(string category)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Category>.Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}