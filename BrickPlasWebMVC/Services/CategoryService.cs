using BrickplasWebCore.Model;
using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Repositories;

namespace BrickPlasWebMVC.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository CategoryRepository)
        {
            _categoryRepository = CategoryRepository;
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

        public async Task<List<Category>> GetAll()
        {
            return await _categoryRepository.GetAll(); ;
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
