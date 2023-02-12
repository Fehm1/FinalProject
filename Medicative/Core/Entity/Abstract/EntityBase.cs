namespace Core.Entity.Abstract
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
