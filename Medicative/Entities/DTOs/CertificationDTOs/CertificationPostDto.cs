using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.CertificationDTOs
{
    public class CertificationPostDto
    {
        [Required]
        public int DoctorId { get; set; }
        [StringLength(150)]
        public string Text { get; set; }
    }
}
