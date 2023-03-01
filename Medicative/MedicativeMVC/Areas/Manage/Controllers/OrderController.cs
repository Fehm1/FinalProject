using Core.Utilities.Complex_types;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Order> orders = await _context.Orders.Where(x => x.IsDeleted == false).ToListAsync();

            return View(orders);
        }

        public async Task<IActionResult> Detail(int id)
        {
            List<OrderItem> orderItems = await _context.OrderItems.Include(x => x.Product).Where(x => x.OrderId == id).ToListAsync();

            return View(orderItems);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            List<OrderItem> orderItem = await _context.OrderItems.Include(x => x.Product).Where(x => x.OrderId == id).ToListAsync();

            foreach (var item in orderItem)
            {
                item.Product.Count = item.Product.Count + item.Count;
            }

            if (order == null) return NotFound();

            order.OrderStatus = OrderStatus.Rejected;
            _context.SaveChanges();

            return Ok();
        }

        public async Task<IActionResult> Restore(int id)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            List<OrderItem> orderItem = await _context.OrderItems.Include(x => x.Product).Where(x => x.OrderId == id).ToListAsync();

            foreach (var item in orderItem)
            {
                item.Product.Count = item.Product.Count - item.Count;
            }

            if (order == null) return NotFound();

            order.OrderStatus = OrderStatus.Pending;
            _context.SaveChanges();

            return Ok();
        }

        public async Task<IActionResult> Read(int id)
        {
            Order order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);

            if (order == null) return NotFound();

            order.OrderStatus = OrderStatus.Accepted;
            _context.SaveChanges();

            return Ok();
        }

    }
}
