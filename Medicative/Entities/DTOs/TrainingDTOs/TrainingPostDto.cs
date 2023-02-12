using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.TrainingDTOs
{
    public class TrainingPostDto
    {
        [Required]
        public int DoctorId { get; set; }

        [Required]
        [StringLength(150)]
        public string Text { get; set; }
    }
}
