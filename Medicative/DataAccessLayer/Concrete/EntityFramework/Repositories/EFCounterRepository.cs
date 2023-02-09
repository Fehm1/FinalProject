using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFCounterRepository : EFBaseRepository<Counter>, ICounterRepository
    {
        public EFCounterRepository(DbContext context) : base(context)
        {
        }
    }
}
