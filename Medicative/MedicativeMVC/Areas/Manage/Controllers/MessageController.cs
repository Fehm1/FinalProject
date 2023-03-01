using Business.Abstract;
using Core.Utilities.Complex_types;
using Entities.DTOs.ContactDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "Admin")]
    public class MessageController : Controller
    {
        private readonly IContactService _contactService;

        public MessageController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _contactService.GetAllByNonDeleteAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        public async Task<IActionResult> DeletedTable()
        {
            var result = await _contactService.GetAllDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactPostDto contactPost)
        {
            if (ModelState.IsValid)
            {
                var result = await _contactService.AddAsync(contactPost);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("contact", "home", new {area = ""});
                }
            }

            return RedirectToAction("contact", "home", new {area = ""});
        }

        public async Task<IActionResult> Detail(int id)
        {
            var result = await _contactService.GetAsync(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return NotFound();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _contactService.Delete(id);
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
            var result = await _contactService.HardDelete(id);
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
            var result = await _contactService.Restore(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Status(int id)
        {
            var result = await _contactService.Status(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return RedirectToAction("index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
