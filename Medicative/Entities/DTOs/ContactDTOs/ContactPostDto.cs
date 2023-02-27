using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.ContactDTOs
{
    public class ContactPostDto
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
