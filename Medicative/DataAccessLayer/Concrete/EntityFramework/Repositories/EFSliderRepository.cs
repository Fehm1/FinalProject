using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFSliderRepository : EFBaseRepository<Slider>, ISliderRepository
    {
        public EFSliderRepository(DbContext context) : base(context)
        {
        }
    }
}
