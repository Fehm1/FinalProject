using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.ProfessionDTOs
{
    public class ProfessionPostDto
    {
        [Required]
        [StringLength(150)]
        public string Icon { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }
    }
}
