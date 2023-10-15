using BrickplasWebCore.Model;
using BrickPlasWebMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;

        public ShopController(ILogger<ShopController> logger,
                             ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        private async Task<IActionResult> getCatalog()
        {
            List<Product> products = ;
            List<Category> categories = ;
        }
    }
}
