using Core.Entity.Abstract;

namespace Entities.Concrete
{
    public class Size : EntityBase ,IEntity
    {
        public string Text { get; set; }

        public List<Medicine> Medicines { get; set; }
    }
}
