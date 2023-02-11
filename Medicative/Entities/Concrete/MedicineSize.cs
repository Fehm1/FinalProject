using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class MedicineSize : EntityBase, IEntity
    {
        public int MedicineId { get; set; }
        public string Size { get; set; }

        public Medicine Medicine { get; set; }
    }
}
