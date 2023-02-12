using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.MedicineDTOs
{
    public class MedicinePostDto
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(750)]
        public string Description { get; set; }

        public IFormFile? FormFile { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public double Price { get; set; }

        public bool BestProduct { get; set; }

        public bool BestSeller { get; set; }
    }
}
