using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Certification : EntityBase, IEntity
    {
        public int DoctorId { get; set; }
        public string Text { get; set; }

        public int MyProperty { get; set; }

        public Doctor Doctor { get; set; }
    }
}
