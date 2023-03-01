using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.CategoryDTOs
{
    public class CategoryPostDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
