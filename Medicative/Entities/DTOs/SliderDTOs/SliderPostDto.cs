using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.SliderDTOs
{
    public class SliderPostDto
    {
        [Required]
        [StringLength(100)]
        public string TitleWhite { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleGreen { get; set; }

        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        public IFormFile? FormFile { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.Url)]
        public string RedirectURL { get; set; }
    }
}
