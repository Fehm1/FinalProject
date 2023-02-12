using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class MedicineSize : IEntity
    {
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}
