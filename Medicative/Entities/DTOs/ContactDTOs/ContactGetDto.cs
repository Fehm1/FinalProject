using Entities.Concrete;

namespace Entities.DTOs.ContactDTOs
{
    public class ContactGetDto
    {
        public virtual int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public Doctor? Doctor { get; set; }
    }
}
