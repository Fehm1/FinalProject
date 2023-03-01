using Core.Entity.Concrete;
using Core.Utilities.Complex_types;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs.AppUserDTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicativeMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register user)
        {
            if (!ModelState.IsValid) return View(user);
            AppUser member = await _userManager.FindByNameAsync(user.UserName);

            if (member != null)
            {
                ModelState.AddModelError("UserName", "Username exist!");
                return View(user);
            }

            member = await _userManager.FindByEmailAsync(user.Email);

            if (member != null)
            {
                ModelState.AddModelError("Email", "Email exist!");
                return View(user);
            }

            member = new AppUser
            {
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email,
                PhoneNumber = user.Phone,
                Address = user.Address,
                Country = user.Country,
                City = user.City,
                IsAdmin = false,
                IsDeleted = false
            };

            var result = await _userManager.CreateAsync(member, user.Password);
            if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                    return View(user);
                }
            }

            await _userManager.AddToRoleAsync(member, "Member");

            return RedirectToAction("login", "account");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login userLogin)
        {
            AppUser member = await _userManager.FindByNameAsync(userLogin.UserName);
            if (member == null)
            {
                ModelState.AddModelError("", "Username or password is invalid!");
                return View(userLogin);
            }

            var result = await _signInManager.PasswordSignInAsync(member, userLogin.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is invalid!");
                return View(userLogin);
            }

            return RedirectToAction("index", "home");
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> Order()
        {
            AppUser appUser = null;
            if (User.Identity.IsAuthenticated)
            {
                appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            List<Order> orders = await _context.Orders.Where(x => x.UserId == appUser.Id).ToListAsync();

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

            if (order != null)
            {
                order.OrderStatus = OrderStatus.Rejected;
                _context.SaveChanges();
                return Ok();
            }

            return NotFound();
        }
    }
}
