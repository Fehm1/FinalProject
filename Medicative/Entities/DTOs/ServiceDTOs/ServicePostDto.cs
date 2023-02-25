using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.ServiceDTOs
{
    public class ServicePostDto
    {
        [Required]
        [StringLength(150)]
        public string Icon { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        [StringLength(150)]
        public string RedirectURL { get; set; }
    }
}
