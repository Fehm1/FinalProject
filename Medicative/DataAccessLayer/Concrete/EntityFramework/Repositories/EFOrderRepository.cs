using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFOrderRepository : EFBaseRepository<Order>, IOrderRepository
    {
        public EFOrderRepository(DbContext context) : base(context)
        {
        }
    }
}
