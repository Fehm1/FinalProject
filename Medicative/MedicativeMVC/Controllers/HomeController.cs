using DataAccessLayer.Concrete.EntityFramework.Context;
using MedicativeMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicativeMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders = await _context.Sliders.Where(x => x.IsDeleted == false).ToListAsync(),
                Services = await _context.Services.Where(x => x.IsDeleted == false).ToListAsync(),
                Departments = await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync(),
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Counters = await _context.Counters.Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };

            return View(homeViewModel);
        }

        public IActionResult Contact()
        {
            return View();
        }

        //public IActionResult BlogDetail(int id)
        //{
        //    return View();
        //}
    }
}