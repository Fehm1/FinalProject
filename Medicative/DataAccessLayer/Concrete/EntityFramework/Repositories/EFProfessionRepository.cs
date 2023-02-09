using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFProfessionRepository : EFBaseRepository<Profession>, IProfessionRepository
    {
        public EFProfessionRepository(DbContext context) : base(context)
        {
        }
    }
}
