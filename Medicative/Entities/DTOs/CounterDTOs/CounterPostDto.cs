using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs.CounterDTOs
{
    public class CounterPostDto
    {
        [StringLength(150)]
        public string Icon { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [Range(0, int.MaxValue)]
        public int Count { get; set; }
    }
}
