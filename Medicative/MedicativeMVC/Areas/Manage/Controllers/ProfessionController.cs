using Business.Abstract;
using Entities.DTOs.ProfessionDTOs;
using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProfessionController : Controller
    {
        private readonly IProfessionService _professionService;

        public ProfessionController(IProfessionService professionService)
        {
            _professionService = professionService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _professionService.GetAllAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProfessionPostDto professionPost)
        {
            if (!ModelState.IsValid)
            {
                return View(professionPost);
            }
            await _professionService.AddAsync(professionPost);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _professionService.GetUpdateDto(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ProfessionUpdateDto  professionUpdate)
        {
            if (!ModelState.IsValid)
            {
                return View(professionUpdate);
            }
            await _professionService.Update(professionUpdate);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _professionService.Delete(id);

            return RedirectToAction("index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HardDelete(int id)
        {
            await _professionService.HardDelete(id);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Restore(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
