using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.SkillDTOs
{
    public class SkillPostDto
    {
        [Required]
        public int DoctorId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public int Percent { get; set; }
    }
}
