using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.SettingDTOs
{
    public class SettingPostDto
    {
        [StringLength(200)]
        public string? Key { get; set; }

        [StringLength(500)]
        public string? Value { get; set; }

        public IFormFile? FormFile { get; set; }
    }
}
