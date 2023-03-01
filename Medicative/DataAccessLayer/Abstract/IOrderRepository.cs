using Core.DAL.Abstract;
using Entities.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
