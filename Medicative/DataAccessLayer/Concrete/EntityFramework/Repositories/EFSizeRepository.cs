using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFSizeRepository : EFBaseRepository<Size>, ISizeRepository
    {
        public EFSizeRepository(DbContext context) : base(context)
        {
        }
    }
}
