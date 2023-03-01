using Entities.Concrete;

namespace Entities.DTOs.CategoryDTOs
{
    public class CategoryGetDto
    {
        public virtual int Id { get; set; }

        public string Name { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public List<Product> Products { get; set; }
    }
}
