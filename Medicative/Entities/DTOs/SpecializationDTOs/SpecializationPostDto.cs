using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.SpecializationDTOs
{
    public class SpecializationPostDto
    {
        [Required]
        [StringLength(150)]
        public string Text { get; set; }
    }
}
