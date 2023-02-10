using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class MedicineSize : EntityBase, IEntity
    {
        public string Size { get; set; }

        public List<Medicine> Medicines { get; set; }
    }
}
