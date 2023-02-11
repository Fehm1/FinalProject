using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Medicine : EntityBase, IEntity
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public bool BestProduct { get; set; }
        public bool BestSeller { get; set; }

        public MedicineCategory MedicineCategory { get; set; }
        public List<MedicineSize> MedicineSizes { get; set; }
    }
}
