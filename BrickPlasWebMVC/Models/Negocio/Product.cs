namespace BrickplasWebCore.Model
{
    public class Product
    {

        public int Id { get; set; }
        public string Details { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Urlmage { get; set; }
        public string ImageBase64 { get; set; }
        public int Stock { get; set; }
        public string Size { get; set; }
        public float Weigth { get; set; }

    }
}
