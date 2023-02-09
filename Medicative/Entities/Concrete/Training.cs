using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Training : EntityBase,IEntity
    {
        public int DoctorId { get; set; }
        public string Text { get; set; }

        public Doctor Doctor { get; set; }
    }
}
