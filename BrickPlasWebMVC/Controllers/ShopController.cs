using BrickplasWebCore.Model;
using BrickPlasWebMVC.Services;
using BrickPlasWebMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel;

namespace BrickPlasWebMVC.Controllers
{
    public class CarritoItem
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
    public class ShopController : Controller
    {
        private readonly ILogger<ShopController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        List<Product> productsCheck;

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

        public IActionResult Checkout()
        {
            string carritoCookie = Request.Cookies["MiCarrito"];
            List<CarritoItem> carrito;
 

            if (carritoCookie != null)
            {
                carrito = JsonConvert.DeserializeObject<List<CarritoItem>>(carritoCookie);
            }
            else
            {
                carrito = new List<CarritoItem>();
            }

            foreach (CarritoItem item in carrito)
            {

                productsCheck.Add(_productService.GetById(item.ProductId).Result);
            }


            return View(new CheckoutViewModel(productsCheck));
        }


        [HttpPost]
        public IActionResult AgregarAlCarrito(IFormCollection itemForm)
        {

            // Obtén el carrito actual desde la cookie o crea uno nuevo
            List<CarritoItem> carrito;
            string carritoCookie = Request.Cookies["MiCarrito"];

            if (carritoCookie != null)
            {
                carrito = JsonConvert.DeserializeObject<List<CarritoItem>>(carritoCookie);
            }
            else
            {
                carrito = new List<CarritoItem>();
            }

            // Añade el nuevo artículo al carrito
            var carritoItem = new CarritoItem
            {
                ProductId = int.Parse(itemForm["prodid"]),
                Name = itemForm["Name"],
                Price = float.Parse(itemForm["Price"]),
                Quantity = int.Parse(itemForm["Quantity"])
            };

            carrito.Add(carritoItem);

            // Guarda el carrito actualizado en la cookie
            Response.Cookies.Append("MiCarrito", JsonConvert.SerializeObject(carrito));

            //// Redirecciona a la página del carrito o a donde desees
            return View();
        }

        public IActionResult VerCarrito()
        {
            // Obtén el carrito actual desde la cookie o crea uno nuevo si está vacío
            string carritoCookie = Request.Cookies["MiCarrito"];
            List<CarritoItem> carrito;

            if (carritoCookie != null)
            {
                carrito = JsonConvert.DeserializeObject<List<CarritoItem>>(carritoCookie);
            }
            else
            {
                carrito = new List<CarritoItem>();
            }

            return View(carrito);
        }

    }
}
