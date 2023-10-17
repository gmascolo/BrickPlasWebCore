using BrickPlasWebMVC.Repositories;
using BrickPlasWebMVC.Services;

namespace BrickPlasWebMVC.Common
{
    public static class AddServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
