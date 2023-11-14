using BrickPlasWebMVC.Models.Negocio;

namespace BrickPlasWebMVC.Services
{
    public interface IProductService : IGenericService<Product>
    {
        Task<Category> GetProductByName(string Product);
    }
}
