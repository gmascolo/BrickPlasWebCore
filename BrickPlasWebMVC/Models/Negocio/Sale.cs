

using System.ComponentModel.DataAnnotations;
using BrickPlasWebMVC.Models.Negocio;

namespace BrickPlasWebMVC.Models.Negocio
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public User ClientId { get; set; }
        public Address DeliveryAddress { get; set; }
        public DateTime ShippingDate { get; set; }
        public List<SaleItem> Items { get; set; }

    }
}
