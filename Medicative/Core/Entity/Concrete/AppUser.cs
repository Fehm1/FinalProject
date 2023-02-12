using Microsoft.AspNetCore.Identity;

namespace Core.Entity.Concrete
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
    }
}
