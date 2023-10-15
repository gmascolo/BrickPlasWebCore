using BrickPlasWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BrickPlasWebMVC.Controllers
{
    public class BackofficeController : Controller
    {
        private readonly ILogger<BackofficeController> _logger;

        public BackofficeController(ILogger<BackofficeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
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