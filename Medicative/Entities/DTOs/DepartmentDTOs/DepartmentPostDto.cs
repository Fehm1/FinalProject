using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.DepartmentDTOs
{
    public class DepartmentPostDto
    {
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(150)]
        public string SubTitle { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Range(0, int.MaxValue)]
        public int InvestigationFee { get; set; }

        [Range(0, int.MaxValue)]
        public int TreatmentFee { get; set; }

        [StringLength(200)]
        [DataType(DataType.Url)]
        public string RedirectURL { get; set; }
    }
}
