using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Slider : EntityBase, IEntity
    {
        public string TitleWhite { get; set; }
        public string TitleGreen { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public string RedirectURL { get; set; }
    }
}
