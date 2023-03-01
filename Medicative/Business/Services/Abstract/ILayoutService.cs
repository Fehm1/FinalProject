using Core.Entity.Concrete;
using Entities.Concrete;

namespace Business.Services.Abstract
{
    public interface ILayoutService
    {
        public Task<List<Setting>> GetSettings();
        public Task<AppUser> GetUser();
    }
}
