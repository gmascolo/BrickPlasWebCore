using BrickPlasWebMVC.Models.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.ViewModel
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        //private Task<IActionResult> products;
        //private Task<IActionResult> categories;

        public ProductViewModel(List<Product> products, List<Category> categories)
        {
            this.Products = products;
            Categories = categories;
        }

    }
}
