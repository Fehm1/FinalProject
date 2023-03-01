using Core.Entity.Abstract;
using Core.Entity.Concrete;

namespace Entities.Concrete
{
    public class BasketItem : EntityBase, IEntity
    {
        public string  UserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }


        public AppUser? User { get; set; }
        public Product? Product { get; set; }
    }
}
