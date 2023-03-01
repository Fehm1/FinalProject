using Core.Utilities.Complex_types;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using MedicativeMVC.Areas.Manage.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Doctor> doctors = await _context.Doctors.Where(x => x.IsDeleted == false).ToListAsync();
            List<Department> departments = await _context.Departments.ToListAsync();
            List<Product> products = await _context.Products.Where(x => x.IsDeleted == false).ToListAsync();
            List<Contact> contacts = await _context.Contacts.Where(x => x.IsActive == true).ToListAsync();
            List<Order> orders = await _context.Orders.Where(x => x.OrderStatus == OrderStatus.Pending).ToListAsync();

            DashboardViewModel dashboardViewModel = new DashboardViewModel
            {
                Doctors = doctors.Count(),
                Departments = departments.Count(),
                Products = products.Count(),
                Orders = orders.Count(),
                Messages = contacts.Count()
            };

            return View(dashboardViewModel);
        }
    }
}
