using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Repositories;

namespace BrickPlasWebMVC.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> Create(User entity)
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

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByName(string username)
        {
            return  await _userRepository.GetUserByName(username);    
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
