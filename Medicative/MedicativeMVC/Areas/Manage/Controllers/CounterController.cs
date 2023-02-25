using Business.Abstract;
using Core.Utilities.Complex_types;
using DataAccessLayer.Abstract;
using Entities.DTOs.CounterDTOs;
using Entities.DTOs.ProfessionDTOs;
using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CounterController : Controller
    {
        private readonly ICounterService _counterService;

        public CounterController(ICounterService counterService)
        {
            _counterService = counterService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _counterService.GetAllByNonDeleteAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }

        public async Task<IActionResult> DeletedTable()
        {
            var result = await _counterService.GetAllByDeletedAsync();
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
        public async Task<IActionResult> Create(CounterPostDto counterPost)
        {
            if (ModelState.IsValid)
            {
                var result = await _counterService.AddAsync(counterPost);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }

            return View(counterPost);
        }

        public async Task<IActionResult> Update(int id)
        {
            var result = await _counterService.GetUpdateDto(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CounterUpdateDto counterUpdate)
        {
            if (!ModelState.IsValid)
            {
                var result = await _counterService.Update(counterUpdate);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }

            return View(counterUpdate);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _counterService.Delete(id);
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
            var result = await _counterService.HardDelete(id);
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
            var result = await _counterService.Restore(id);
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
