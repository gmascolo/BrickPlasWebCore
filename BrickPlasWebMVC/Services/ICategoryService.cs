using BrickPlasWebMVC.Models.Negocio;

namespace BrickPlasWebMVC.Services
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<Category> GetCategoryByName(string Category);
    }
}
