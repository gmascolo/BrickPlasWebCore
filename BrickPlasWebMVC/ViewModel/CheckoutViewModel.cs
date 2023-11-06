using BrickplasWebCore.Model;
using Microsoft.AspNetCore.Mvc;

namespace BrickPlasWebMVC.ViewModel
{
    public class CheckoutViewModel
    {
        public List<Product> products { get; set; }


        public CheckoutViewModel(List<Product> products)
        {
            this.products = products;
        }

    }
}
