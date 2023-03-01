using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.ProductDTOs
{
    public class ProductPostDto
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }

        public IFormFile? FormFile { get; set; }

        [Required]
        public int Count { get; set; }

        public double Price { get; set; }

        public byte DiscountPercent { get; set; }

        public bool IsPopular { get; set; } = false;

        public bool TopSeller { get; set; } = false;
    }
}
