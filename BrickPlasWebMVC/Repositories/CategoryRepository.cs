using BrickplasWebCore.Model;
using BrickPlasWebMVC.Data;
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

        Task<List<Category>> IGenericRepository<Category>.GetAll()
        {
            throw new NotImplementedException();
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
