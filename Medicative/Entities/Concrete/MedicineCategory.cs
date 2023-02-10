using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class MedicineCategory : EntityBase, IEntity
    {
        public string Category { get; set; }

        public List<Medicine> Medicines { get; set; }
    }
}
