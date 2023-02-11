using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFDepartmentImageRepository : EFBaseRepository<DepartmentImage>, IDepartmentImageRepository
    {
        public EFDepartmentImageRepository(DbContext context) : base(context)
        {
        }
    }
}
