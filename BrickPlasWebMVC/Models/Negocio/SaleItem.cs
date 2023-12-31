﻿

using System.ComponentModel.DataAnnotations;

namespace BrickplasWebCore.Model
{
    public class SaleItem
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal Subtotal { get; set; }
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        public decimal Quantity { get; set; }
    }
}