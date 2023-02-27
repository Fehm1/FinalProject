using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.CertificationDTOs
{
    public class CertificationPostDto
    {
        [Required]
        [StringLength(200)]
        public string Text { get; set; }
    }
}