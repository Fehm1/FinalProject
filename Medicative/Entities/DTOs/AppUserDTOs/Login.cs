using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.AppUserDTOs
{
    public class Login
    {
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength:20, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
