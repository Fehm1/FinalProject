using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFMedicineRepository : EFBaseRepository<Medicine>, IMedicineRepository
    {
        public EFMedicineRepository(DbContext context) : base(context)
        {
        }
    }
}
