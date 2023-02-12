using Entities.Concrete;

namespace Entities.DTOs.ProfessionDTOs
{
    public class ProfessionGetDto
    {
        public virtual int Id { get; set; }
        
        public string Icon { get; set; }
        public string Name { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public List<Doctor>? Doctors { get; set; }
    }
}
