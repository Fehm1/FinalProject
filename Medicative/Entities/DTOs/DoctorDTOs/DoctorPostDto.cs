using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.DoctorDTOs
{
    public class DoctorPostDto
    {
        [Required]
        public int ProfessionId { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        public IFormFile? formFile { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.Url)]
        public string InstagramURL { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.Url)]
        public string FacebookURL { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.Url)]
        public string TwitterURL { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.Url)]
        public string LinekedInURL { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.Url)]
        public string RedirectURL { get; set; }

    }
}
