using System.ComponentModel.DataAnnotations;
using BrickPlasWebMVC.Models.Negocio;

namespace BrickplasWebCore.Model
{
    public class Order
    {

        public int Id { get; set; }

        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
        public User Client { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ShippingDate { get; set; }
    }
}

