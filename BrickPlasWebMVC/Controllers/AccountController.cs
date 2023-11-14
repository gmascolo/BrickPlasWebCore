using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Services;
using BrickPlasWebMVC.ViewModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BrickPlasWebMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUserService _userService;

        public class Role
        {
            public int RoleId { get; set; }
            public string RoleName { get; set; }

            public virtual ICollection<UserRole> UserRoles { get; set; }
        }

        public class UserRole
        {
            public int UserId { get; set; }
            public virtual User User { get; set; }

            public int RoleId { get; set; }
            public virtual Role Role { get; set; }
        }

        public AccountController(ILogger<AccountController> logger,
                              IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult Shop()
        {

            return Redirect("/Shop");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProcessLogin(IFormCollection loginForm)
        {
            if (loginForm == null)
            {
                return View("Error");
            }
            else
            {
                return await ValidateLogin(loginForm);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(IFormCollection registerForm)
        {

            var user = new User()
            {
                UserName = registerForm["nombreUsuario"],
                Password = registerForm["contrasena"],
                Email = registerForm["email"],
                FirstName = registerForm["nombre"],
                LastName = registerForm["apellido"],
                DocumentType = registerForm["tdocumento"],
                DocumentNumber = registerForm["documento"],
                CUIT = registerForm["cuit"],
                PhoneNumber = registerForm["telefono"],
                NormalizedUserName = registerForm["nombreUsuario"],
                NormalizedEmail = registerForm["email"],
                PhoneNumberConfirmed = true,
                EmailConfirmed = true

            };

            bool result = await _userService.Create(user);

            if (result == true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Register");
            }
        }

        private async Task<IActionResult> ValidateLogin(IFormCollection loginForm)
        {

            var username = loginForm["nombreUsuario"];
            var password = loginForm["contrasena"];

            User user = await _userService.GetUserByName(username);
            //UserRole userRoles = ;

            if (user == null)
            {
                return View("Login", new ValidateViewModel() { Visible = true });
            }

            if (username == user.UserName && password == user.Password)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                // Puedes añadir más claims aquí si es necesario
            };
             
            //foreach (var role in userRoles) // userRoles debe ser una lista de roles del usuario
            //{
            //        claims.Add(new Claim(ClaimTypes.Role, role));
            //}
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                return RedirectToAction("Index","Home");
            }
            else
            {
                return View("Login");
            }
        }

        public IActionResult Register()
        {
            return View("Register");
        }
    }
}
