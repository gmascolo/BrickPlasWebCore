using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Services;

namespace BrickPlasWebMVC.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserByName(string username);
    }
}