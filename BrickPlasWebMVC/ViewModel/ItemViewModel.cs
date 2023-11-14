using BrickPlasWebMVC.Models.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.ViewModel
{
    public class ItemViewModel
    {
        public Product product { get; set; }
        public List<Category> categories { get; set; }

        public ItemViewModel(Product product, List<Category> categories)
        {
            this.product = product;
            this.categories = categories;
        }

    }
}
