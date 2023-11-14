using BrickPlasWebMVC.Models.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.ViewModel
{
    public class ItemViewModel
    {
        public Product product { get; set; }

        public ItemViewModel(Product product)
        {
            this.product = product;
        }

    }
}
