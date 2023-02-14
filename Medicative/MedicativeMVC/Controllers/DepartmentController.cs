using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Cardilogists()
        {
            return View();
        }

        public IActionResult Orthopaedics()
        {
            return View();
        }

        public IActionResult Gastronelogy()
        {
            return View();
        }

        public IActionResult Neuroscien()
        {
            return View();
        }

        public IActionResult Spine()
        {
            return View();
        }

        public IActionResult Cancer()
        {
            return View();
        }
    }
}
