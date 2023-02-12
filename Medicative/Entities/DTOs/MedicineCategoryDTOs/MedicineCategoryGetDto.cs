using Entities.Concrete;

namespace Entities.DTOs.MedicineCategoryDTOs
{
    public class MedicineCategoryGetDto
    {
        public virtual int Id { get; set; }

        public string Category { get; set; }
        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public List<Medicine>? Medicines { get; set; }
    }
}
