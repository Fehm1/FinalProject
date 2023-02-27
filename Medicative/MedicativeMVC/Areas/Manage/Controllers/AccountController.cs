using Core.Entity.Concrete;
using Entities.DTOs.AppUserDTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> CreateRole()
        {
            IdentityRole role1 = new IdentityRole("Admin");
            IdentityRole role2 = new IdentityRole("Member");

            await _roleManager.CreateAsync(role1);
            await _roleManager.CreateAsync(role2);

            return Ok("OK!");
        }

        public async Task<IActionResult> CreateAdmin()
        {
            AppUser admin = new AppUser
            {
                UserName = "Admin",
                FullName = "Admin Adminov"
            };

            var result = await _userManager.CreateAsync(admin, "admin123");

            await _userManager.AddToRoleAsync(admin, "Admin");

            return Ok(result);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login adminLogin)
        {
            AppUser admin = await _userManager.FindByNameAsync(adminLogin.UserName);
            if (admin == null)
            {
                ModelState.AddModelError("", "Username or password is invalid!");
                return View(adminLogin);
            }

            var result = await _signInManager.PasswordSignInAsync(admin, adminLogin.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is invalid!");
                return View(adminLogin);
            }

            return RedirectToAction("Index", "dashboard");
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();

            return RedirectToAction("index", "home", new { area = "" });
        }
    }
}
