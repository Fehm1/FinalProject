using Core.DAL.Concrete.EntityFramework;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework.Repositories
{
    public class EFTrainingRepository : EFBaseRepository<Training>, ITrainingRepository
    {
        public EFTrainingRepository(DbContext context) : base(context)
        {
        }
    }
}
