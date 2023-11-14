using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Services;

namespace BrickPlasWebMVC.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetCategoryByName(string category);
    }
}