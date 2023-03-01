using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Category : EntityBase, IEntity
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
