using BrickplasWebCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.ViewModel
{
    public class ShopViewModel
    {
        public List<Product> products { get; set; }
        public List<Category> categories { get; set; }
        //private Task<IActionResult> products;
        //private Task<IActionResult> categories;

        public ShopViewModel(List<Product> products, List<Category> categories)
        {
            this.products = products;
            this.categories = categories;
        }

    }
}
