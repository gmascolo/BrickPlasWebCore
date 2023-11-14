using BrickPlasWebMVC.Models.Negocio;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.ViewModel
{
    public class UserViewModel
    {
        public List<IdentityUser> users { get; set; }

        public UserViewModel(List<IdentityUser> users)
        {
            this.users = users;
        }

    }
}
