using BrickplasWebCore.Model;
using BrickPlasWebMVC.Data;
using BrickPlasWebMVC.Services;
using Microsoft.EntityFrameworkCore;

namespace BrickPlasWebMVC.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        Task<bool> IGenericRepository<Product>.Create(Product entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Product>.Delete(int? id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Product>.DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        async Task<List<Product>> IGenericRepository<Product>.GetAll()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        Task<Product> IGenericRepository<Product>.GetById(int? id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IGenericRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
