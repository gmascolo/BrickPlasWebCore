using BrickplasWebCore.Model;
using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Repositories;

namespace BrickPlasWebMVC.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _CategoryRepository;

        public CategoryService(ICategoryRepository CategoryRepository)
        {
            _CategoryRepository = CategoryRepository;
        }

        public Task<bool> Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryByName(string Category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Category entity)
        {
            throw new NotImplementedException();
        }
    } 
}
