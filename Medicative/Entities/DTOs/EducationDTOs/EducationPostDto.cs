using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.EducationDTOs
{
    public class EducationPostDto
    {
        [Required]
        public int DoctorId { get; set; }

        [Required]

        public string Text { get; set; }
    }
}
