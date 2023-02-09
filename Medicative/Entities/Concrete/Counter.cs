using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Counter : EntityBase, IEntity
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
