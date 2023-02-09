using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFDepartmentRepository : EFBaseRepository<Department>, IDepartmentRepository
    {
        public EFDepartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
