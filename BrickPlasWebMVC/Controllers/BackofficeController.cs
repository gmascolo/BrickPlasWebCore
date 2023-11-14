using BrickPlasWebMVC.Models;
using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Services;
using BrickPlasWebMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace BrickPlasWebMVC.Controllers
{
    public class BackofficeController : Controller
    {
        private readonly ILogger<BackofficeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public BackofficeController(ILogger<BackofficeController> logger,
                                    ICategoryService categoryService,
                                    IProductService productService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult EditProd() { 

        
            return View();
        }

        public IActionResult Productos()
        {
            List<Product> products = _productService.GetAll().Result;
            List<Category> categories = _categoryService.GetAll().Result;
            var currentShop = new ProductViewModel(products, categories);
            string json = JsonConvert.SerializeObject(currentShop);

            Response.Cookies.Append("CurrentSession", json);

            return View(currentShop);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}