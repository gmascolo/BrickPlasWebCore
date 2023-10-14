using BrickPlasWebMVC.Data;
using BrickPlasWebMVC.Models.Negocio;
using Microsoft.EntityFrameworkCore;

namespace BrickPlasWebMVC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
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
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);
            //var user = (from u in _context.Users
            //            where u.UserName == username
            //            select u).FirstOrDefault();

            return user;   
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
