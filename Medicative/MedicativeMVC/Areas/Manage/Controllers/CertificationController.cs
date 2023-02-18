using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CertificationController : Controller
    {
        private readonly ICertificationService _certificationService;

        public CertificationController(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _certificationService.GetAllAsync());
        }

    }
}
