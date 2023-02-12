using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.MedicineCategoryDTOs
{
    public class MedicineCategoryPostDto
    {
        [Required]
        [StringLength(200)]
        public string Category { get; set; }
    }
}
