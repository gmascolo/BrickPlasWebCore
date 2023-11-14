using BrickPlasWebMVC.Data;
using BrickPlasWebMVC.Models.Negocio;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static System.Formats.Asn1.AsnWriter;

namespace BrickPlasWebMVC.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       

        public async Task<bool> Create(User entity)
        {
            try
            {
                var user = new IdentityUser();
                user.Email = entity.Email;
                user.PhoneNumber = entity.PhoneNumber;
                user.UserName = entity.UserName;
                user.PhoneNumberConfirmed = entity.PhoneNumberConfirmed;
                user.EmailConfirmed = entity.EmailConfirmed;
                //await UserManager.CreateAsync(user, password);
                //_context.Users.Add(entity);
                //_context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }


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
