using Entities.Concrete;

namespace Entities.DTOs.CounterDTOs
{
    public class CounterGetDto
    {

        public string Icon { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public virtual int Id { get; set; }
        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
