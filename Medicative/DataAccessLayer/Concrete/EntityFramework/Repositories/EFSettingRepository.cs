using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFSettingRepository : EFBaseRepository<Setting>, ISettingRepostory
    {
        public EFSettingRepository(DbContext context) : base(context)
        {
        }
    }
}
