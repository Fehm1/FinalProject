using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.DepartmentDTOs
{
    public class DepartmentPostDto
    {
        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(150)]
        public string SubTitle { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int InvestigationFee { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int TreatmentFee { get; set; }

        [Required]
        [StringLength(300)]
        [DataType(DataType.Url)]
        public string RedirectURL { get; set; }

    }
}
