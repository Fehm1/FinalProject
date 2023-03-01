using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFOrderItemRepository : EFBaseRepository<OrderItem>, IOrderItemRepository
    {
        public EFOrderItemRepository(DbContext context) : base(context)
        {
        }
    }
}
