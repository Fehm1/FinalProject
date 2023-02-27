using Core.Entity.Concrete;

namespace Business.Services.Abstract
{
    public interface IManageLayoutService
    {
        public Task<AppUser> GetAdmin();
        public Task<int> GetMessageCount();
    }
}
