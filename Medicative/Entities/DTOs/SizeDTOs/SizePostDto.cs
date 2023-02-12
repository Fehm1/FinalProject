using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.SizeDTOs
{
    public class SizePostDto
    {
        [Required]
        [StringLength(100)]
        public string Text { get; set; }
    }
}
