

using Microsoft.AspNetCore.Identity;

namespace BrickplasWebCore.Model
{
    public class User : IdentityUser<int>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public List<Address> Address { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string CUIT { get; set; }
        public bool Enabled { get; set; }
        public int LoginAttempts { get; set; }
 
    }
}
