using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Department : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PosterImage { get; set; }
        public string DetailImage { get; set; }
        public int InvestigationFee { get; set; }
        public int TreatmentFee { get; set; }

        public List<Doctor> Doctors { get; set; }
    }
}
