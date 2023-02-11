using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.DepartmentImageDTOs
{
    public class DepartmentImagePostDto
    {
        [Required]
        public int DeparmentId { get; set; }

        public IFormFile? Formfile { get; set; }

        public bool IsPoster { get; set; } = false;
    }
}
