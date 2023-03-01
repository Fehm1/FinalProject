using Entities.Concrete;

namespace Entities.DTOs.ProductDTOs
{
    public class ProductGetDto
    {
        public virtual int Id { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public byte DiscountPercent { get; set; }
        public bool IsPopular { get; set; } = false;
        public bool TopSeller { get; set; } = false;

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public Category Category { get; set; }
    }
}
