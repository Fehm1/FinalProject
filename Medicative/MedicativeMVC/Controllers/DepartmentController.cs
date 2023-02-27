using DataAccessLayer.Concrete.EntityFramework.Context;
using MedicativeMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicativeMVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Cardilogists()
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel()
            {
                Departments = await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync(),
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Counters = await _context.Counters.Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };
            return View(departmentViewModel);
        }

        public async Task<IActionResult> Orthopaedics()
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel()
            {
                Departments = await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync(),
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Counters = await _context.Counters.Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };
            return View(departmentViewModel);
        }

        public async Task<IActionResult> Gastronelogy()
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel()
            {
                Departments = await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync(),
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Counters = await _context.Counters.Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };
            return View(departmentViewModel);
        }

        public async Task<IActionResult> Neuroscien()
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel()
            {
                Departments = await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync(),
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Counters = await _context.Counters.Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };
            return View(departmentViewModel);
        }

        public async Task<IActionResult> Spine()
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel()
            {
                Departments = await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync(),
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Counters = await _context.Counters.Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };
            return View(departmentViewModel);
        }

        public async Task<IActionResult> Cancer()
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel()
            {
                Departments = await _context.Departments.Where(x => x.IsDeleted == false).ToListAsync(),
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Counters = await _context.Counters.Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };
            return View(departmentViewModel);
        }
    }
}
