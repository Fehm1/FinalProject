using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFServiceRepository : EFBaseRepository<Service>, IServiceRepository
    {
        public EFServiceRepository(DbContext context) : base(context)
        {
        }
    }
}
