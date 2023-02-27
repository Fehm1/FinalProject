using Business.Services.Abstract;
using Core.Entity.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Business.Services.Concrete
{
    public class ManageLayoutService : IManageLayoutService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;

        public ManageLayoutService(AppDbContext context, UserManager<AppUser> userManager, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _contextAccessor = contextAccessor;
        }
        public async Task<AppUser> GetAdmin()
        {
            AppUser admin = null;
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                admin = await _userManager.FindByNameAsync(_contextAccessor.HttpContext.User.Identity.Name);
                return admin;
            }
            return null;
        }

        public async Task<int> GetMessageCount()
        {
            List<Contact> contacts = await _context.Contacts.Where(x => x.IsActive == true).ToListAsync();

            return contacts.Count();
        }
    }
}
