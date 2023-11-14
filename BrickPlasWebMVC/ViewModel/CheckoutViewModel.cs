using BrickPlasWebMVC.Models.Negocio;
using System.Xml.Schema;

namespace BrickPlasWebMVC.ViewModel
{
    public class CheckoutViewModel
    {
        public List<Product> products { get; set; }
        public decimal subtotal { get; set; }
        public decimal totalprice { get; set; }
        public decimal shipping { get; set; }


        public CheckoutViewModel(List<Product> products, decimal totalprice, decimal subtotal, decimal shipping)
        {
            this.products = products;
            this.totalprice = totalprice;
            this.subtotal = subtotal;
            this.shipping = shipping;


        }

    }
}
