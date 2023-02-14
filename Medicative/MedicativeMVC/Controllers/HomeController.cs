using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult BlogDetail(int id)
        {
            return View();
        }
    }
}