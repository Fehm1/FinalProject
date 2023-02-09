using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Service : EntityBase, IEntity
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RedirectURL { get; set; }
    }
}
