using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.EducationDTOs
{
    public class EducationPostDto
    {
        [Required]
        public string Text { get; set; }
    }
}
