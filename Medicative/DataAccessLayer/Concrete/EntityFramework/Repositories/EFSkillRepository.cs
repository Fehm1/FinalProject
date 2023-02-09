using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFSkillRepository : EFBaseRepository<Skill>, ISkillRepository
    {
        public EFSkillRepository(DbContext context) : base(context)
        {
        }
    }
}
