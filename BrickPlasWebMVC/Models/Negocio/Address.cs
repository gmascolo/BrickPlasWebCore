namespace BrickPlasWebMVC.Models.Negocio
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string AddressNumber { get; set; }
        public string Floor { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string CountryId { get; set; }
        public string ZipCode { get; set; }
        public EnumAddressType Type { get; set; }
    }
}