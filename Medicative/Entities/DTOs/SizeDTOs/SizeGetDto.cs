using Entities.Concrete;

namespace Entities.DTOs.SizeDTOs
{
    public class SizeGetDto
    {
        public virtual int Id { get; set; }
        
        public string Text { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public List<Medicine>? Medicines { get; set; }
    }
}
