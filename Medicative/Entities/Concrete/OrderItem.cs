using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class OrderItem : EntityBase, IEntity
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public string ProductName { get; set; }
        public double Price { get; set; }
        public byte DiscountPercent { get; set; }
        public int Count { get; set; }

        public Product? Product { get; set; }
        public Order? Order { get; set; }
    }
}
