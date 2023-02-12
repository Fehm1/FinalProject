using Entities.Concrete;

namespace Entities.DTOs.SpecializationDTOs
{
    public class SpecializationGetDto
    {
        public virtual int Id { get; set; }
        public int DoctorId { get; set; }

        public string Text { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public Doctor? Doctor { get; set; }
    }
}
