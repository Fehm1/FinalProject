using Entities.Concrete;

namespace Entities.DTOs.SliderDTOs
{
    public class SliderGetDto
    {
        public virtual int Id { get; set; }
        
        public string TitleWhite { get; set; }
        public string TitleGreen { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string RedirectURL { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
