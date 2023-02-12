using Entities.Concrete;

namespace Entities.DTOs.DepartmentImageDTOs
{
    public class DepartmentImageGetDto
    {
        public virtual int Id { get; set; }
        
        public int DeparmentId { get; set; }

        public string ImageURL { get; set; }
        public bool IsPoster { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public Department? Department { get; set; }
    }
}
