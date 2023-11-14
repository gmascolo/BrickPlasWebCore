using BrickPlasWebMVC.Models.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.ViewModel
{
    public class ShopViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        //private Task<IActionResult> products;
        //private Task<IActionResult> categories;

        public ShopViewModel(List<Product> products, List<Category> categories)
        {
            this.Products = products;
            this.Categories = categories;
        }

    }
}
