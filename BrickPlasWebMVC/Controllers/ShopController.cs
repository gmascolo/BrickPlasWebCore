using BrickplasWebCore.Model;
using BrickPlasWebMVC.Services;
using BrickPlasWebMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace BrickPlasWebMVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public ShopController(ILogger<ShopController> logger,
                             ICategoryService categoryService,
                             IProductService productService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {

            List<Category> categories = _categoryService.GetAll().Result;
            List<Product> products = _productService.GetAll().Result;

            return View(new ShopViewModel(products, categories));
        }

        public IActionResult Item(int id)
        {
            Product product = _productService.GetById(id).Result;

            return View(new ItemViewModel(product));
        }



    }
}
