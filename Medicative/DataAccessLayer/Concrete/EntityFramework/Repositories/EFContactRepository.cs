using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFContactRepository : EFBaseRepository<Contact>, IContactRepository
    {
        public EFContactRepository(DbContext context) : base(context)
        {
        }
    }
}
