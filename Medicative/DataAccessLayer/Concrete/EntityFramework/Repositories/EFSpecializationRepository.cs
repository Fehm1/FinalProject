using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFSpecializationRepository : EFBaseRepository<Specialization>, ISpecializationRepository
    {
        public EFSpecializationRepository(DbContext context) : base(context)
        {
        }
    }
}
