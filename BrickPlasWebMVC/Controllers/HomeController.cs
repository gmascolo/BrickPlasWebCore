using BrickPlasWebMVC.Models;
using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Services;
using BrickPlasWebMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BrickPlasWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, 
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
                Email = ""
            };

            if (await _userService.Create(user))
            {
                return View("Index");
            }
            else
            {
                return View("Register");
            }
        }
       

        private async Task<IActionResult> ValidateLogin(IFormCollection loginForm)
        {

            var username = loginForm["nombreUsuario"];
            var password = loginForm["c"];

            User user = await _userService.GetUserByName(username);

            if(user == null)
            {
                return View("Login", new ValidateViewModel() { Visible = true});
            }

            if (username == user.UserName && password == user.Password)
            {
                return View("Index");
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


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}