using BrickPlasWebMVC.Models.Negocio;

namespace BrickPlasWebMVC.Services
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> GetUserByName(string username);
    }
}
