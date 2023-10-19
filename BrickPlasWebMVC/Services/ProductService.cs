using BrickplasWebCore.Model;
using BrickPlasWebMVC.Repositories;

namespace BrickPlasWebMVC.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        Task<bool> IGenericService<Product>.Create(Product entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericService<Product>.Delete(int? id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericService<Product>.DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        async Task<List<Product>> IGenericService<Product>.GetAll()
        {
            
            return await _productRepository.GetAll();
        }

        async Task<Product> IGenericService<Product>.GetById(int? id)
        {
            return await _productRepository.GetById(id);
        }

        Task<Category> IProductService.GetProductByName(string Product)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericService<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
