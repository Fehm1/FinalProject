using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Product : EntityBase, IEntity
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public byte DiscountPercent { get; set; }
        public bool IsPopular { get; set; } = false;
        public bool TopSeller { get; set; } = false;

        public Category Category { get; set; }
    }
}
