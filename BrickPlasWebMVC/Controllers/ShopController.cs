using BrickPlasWebMVC.Models.Negocio;
using BrickPlasWebMVC.Services;
using BrickPlasWebMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using MercadoPago.Client.Common;
using MercadoPago.Client.Payment;
using MercadoPago.Config;
using MercadoPago.Resource.Payment;

namespace BrickPlasWebMVC.Controllers
{
    public class CarritoItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
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
            var currentShop = new ShopViewModel(products, categories);
            string json = JsonConvert.SerializeObject(currentShop);

            Response.Cookies.Append("CurrentSession", json);

            return View(currentShop);
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
            List<Product> productsCheck = new List<Product>();
            decimal totalprice;
            decimal subtotal = 0;
            decimal shipping = 2000;



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
                Product product = _productService.GetById(item.ProductId).Result;
                product.Quantity = item.Quantity;
                subtotal = product.Price * item.Quantity;
                productsCheck.Add(product);
                
            }
            totalprice = subtotal+shipping;

            return View(new CheckoutViewModel(productsCheck, totalprice, subtotal, shipping));
        }


        [HttpPost]
        public IActionResult AgregarAlCarrito(IFormCollection prodItem)
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
            var carritoItem = new CarritoItem();
            prodItem.TryGetValue("prodID", out StringValues prodID);
            carritoItem.ProductId = int.Parse(prodID);
            prodItem.TryGetValue("prodQty", out StringValues qty);
            carritoItem.Quantity = int.Parse(qty);


            carrito.Add(carritoItem);

            // Guarda el carrito actualizado en la cookie
            Response.Cookies.Append("MiCarrito", JsonConvert.SerializeObject(carrito));

            var jsonCurrentShop = Request.Cookies["CurrentSession"];
            var currentShop = JsonConvert.DeserializeObject<ShopViewModel>(jsonCurrentShop);   
            //// Redirecciona a la página del carrito o a donde desees
            return View("Index", currentShop);
        }

        public IActionResult AgregarAlCarrito(int idProd)
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
            var carritoItem = new CarritoItem();
            carritoItem.ProductId = idProd;
            carritoItem.Quantity = 1;


            carrito.Add(carritoItem);

            // Guarda el carrito actualizado en la cookie
            Response.Cookies.Append("MiCarrito", JsonConvert.SerializeObject(carrito));

            var jsonCurrentShop = Request.Cookies["CurrentSession"];
            var currentShop = JsonConvert.DeserializeObject<ShopViewModel>(jsonCurrentShop);
            //// Redirecciona a la página del carrito o a donde desees
            return View("Index", currentShop);
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

        public IActionResult UpdateCarrito()
        {
            string carritoCookie = Request.Cookies["MiCarrito"];
            List<CarritoItem> carrito;
            List<Product> productsCheck = new List<Product>();
            decimal totalprice=0;
            decimal subtotal = 0;
            decimal shipping = 2000;



            return View(new CheckoutViewModel(productsCheck, totalprice, subtotal, shipping));
        }

        public async IActionResult MercadoPago()
        {
            MercadoPagoConfig.AccessToken = "TEST-2472737360159515-111400-86c167b062a33a5d81b2c8610082cc71-4637730";

            var paymentRequest = new PaymentCreateRequest
            {
                TransactionAmount = decimal.Parse(Request["transactionAmount"]),
                Token = Request["token"],
                Description = Request["description"],
                Installments = int.Parse(Request["installments"]),
                PaymentMethodId = Request["paymentMethodId"],
                Payer = new PaymentPayerRequest
                {
                    Email = Request["cardholderEmail"],
                    Identification = new IdentificationRequest
                    {
                        Type = Request["identificationType"],
                        Number = Request["identificationNumber"],
                    },
                    FirstName = Request["cardholderName"]
                },
            };

            var client = new PaymentClient();
            Payment payment = await client.CreateAsync(paymentRequest);

            return View();
        }

    }
}
