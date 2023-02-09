using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Skill : EntityBase, IEntity
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public int Percent { get; set; }

        public Doctor Doctor { get; set; }
    }
}
