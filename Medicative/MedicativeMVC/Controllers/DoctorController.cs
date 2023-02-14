using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
