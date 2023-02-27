using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Contact : EntityBase, IEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
