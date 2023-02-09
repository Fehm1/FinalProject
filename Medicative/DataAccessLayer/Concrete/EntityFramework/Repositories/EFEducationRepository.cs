using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFEducationRepository : EFBaseRepository<Education>, IEducationRepostory
    {
        public EFEducationRepository(DbContext context) : base(context)
        {
        }
    }
}
