using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Profession : EntityBase, IEntity
    {
        public int DoctorId { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }

        public List<Doctor> Doctors { get; set; }
    }
}
