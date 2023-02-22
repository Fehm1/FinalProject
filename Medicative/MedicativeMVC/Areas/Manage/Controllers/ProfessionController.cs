using Business.Abstract;
using Core.Utilities.Complex_types;
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
            var result = await _professionService.GetAllByNonDeleteAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        public async Task<IActionResult> DeletedTable()
        {
            var result = await _professionService.GetAllByDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProfessionPostDto professionPost)
        {
            if (ModelState.IsValid)
            {
                var result = await _professionService.AddAsync(professionPost);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }
            
            return View(professionPost);
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _professionService.GetUpdateDto(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ProfessionUpdateDto professionUpdate)
        {
            var professionGetDto = await _professionService.GetAsync(professionUpdate.ProfessionGet.Id);
            professionUpdate.ProfessionGet = professionGetDto.Data;
            if (!ModelState.IsValid)
            {
                var result = await _professionService.Update(professionUpdate);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }
                
            return View(professionUpdate);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var result = await _professionService.Delete(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> HardDelete(int id)
        {
            var result = await _professionService.HardDelete(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Restore(int id)
        {
            var result = await _professionService.Restore(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
