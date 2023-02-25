using Entities.Concrete;
using Entities.DTOs.CertificationDTOs;
using Entities.DTOs.EducationDTOs;
using Entities.DTOs.SpecializationDTOs;
using Entities.DTOs.TrainingDTOs;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public List<CertificationPostDto>? CertificationPosts { get; set; }
        public List<int>? CertificationPostsId { get; set; }

        public List<SpecializationPostDto>? SpecializationPosts { get; set; }
        public List<int>? SpecializationPostsId { get; set; }

        public List<TrainingPostDto>? TrainingPosts { get; set; }
        public List<int>? TrainingPostsId { get; set; }

        public List<EducationPostDto>? EducationPosts { get; set; }
        public List<int>? EducationPostsId { get; set; }
    }
}
