using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFMedicineSizeRepository : EFBaseRepository<MedicineSize>, IMedicineSizeRepository
    {
        public EFMedicineSizeRepository(DbContext context) : base(context)
        {
        }
    }
}
