using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.CertificationDTOs
{
    public class CertificationPostDto
    {
        [Required]
        public int DoctorId { get; set; }

        [Required]
        [StringLength(200)]
        public string Text { get; set; }
    }
}