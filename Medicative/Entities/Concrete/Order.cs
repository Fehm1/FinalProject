using Core.Entity.Abstract;
using Core.Entity.Concrete;
using Core.Utilities.Complex_types;

namespace Entities.Concrete
{
    public class Order : EntityBase, IEntity
    {
        public string? UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

        public AppUser? User { get; set; }
        public List<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
    }
}
