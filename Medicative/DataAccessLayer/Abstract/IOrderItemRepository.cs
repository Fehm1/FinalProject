using Core.DAL.Abstract;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
    }
}
