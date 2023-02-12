using Entities.Concrete;

namespace Entities.DTOs.MedicineDTOs
{
    public class MedicineGetDto
    {
        public virtual int Id { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public bool BestProduct { get; set; }
        public bool BestSeller { get; set; }

        public virtual DateTime CreatedTime { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false;
        public virtual bool IsDeleted { get; set; } = false;

        public MedicineCategory? MedicineCategory { get; set; }
        public List<Size>? Size { get; set; }
    }
}
