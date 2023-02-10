using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFMedicineCategoryRepository : EFBaseRepository<MedicineCategory>, IMedicineCategoryRepository
    {
        public EFMedicineCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
