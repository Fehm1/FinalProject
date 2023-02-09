using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class DepartmentImage : EntityBase, IEntity
    {
        public int DeparmentId { get; set; }
        public string ImageURL { get; set; }
        public bool IsPoster { get; set; }

        public Department Department { get; set; }
    }
}
