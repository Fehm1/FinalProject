namespace Entities.DTOs.AppUserDTOs
{
    public class AppUserGetDto
    {
        public string Id { get; set; } 
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }
    }
}
