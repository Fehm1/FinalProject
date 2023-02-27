using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using MedicativeMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicativeMVC.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            DoctorViewModel doctorViewModel = new DoctorViewModel()
            {
                Doctors = await _context.Doctors.Include(x => x.Profession).Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };

            return View(doctorViewModel);
        }

        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.Settings = await _context.Settings.ToListAsync();

            Doctor doctor = await _context.Doctors
                .Include(x => x.Profession)
                .Include(x => x.Certifications)
                .Include(x => x.Training)
                .Include(x => x.Specializations)
                .Include(x => x.Educations)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }
    }
}
