using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFCertificationRepository : EFBaseRepository<Certification>, ICertificationRepository
    {
        public EFCertificationRepository(DbContext context) : base(context)
        {
        }
    }
}
