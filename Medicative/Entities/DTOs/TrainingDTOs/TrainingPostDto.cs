using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.TrainingDTOs
{
    public class TrainingPostDto
    {
        [Required]
        [StringLength(150)]
        public string Text { get; set; }
    }
}
