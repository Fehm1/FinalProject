using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFDoctorRepository : EFBaseRepository<Doctor>, IDoctorRepository
    {
        public EFDoctorRepository(DbContext context) : base(context)
        {
        }
    }
}
