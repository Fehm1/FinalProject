using Business.Abstract;
using Core.Utilities.Complex_types;
using DataAccessLayer.Abstract;
using Entities.DTOs.DoctorDTOs;
using Entities.DTOs.ProfessionDTOs;
using Microsoft.AspNetCore.Mvc;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IUnityOfWork _unityOfWork;

        public DoctorController(IDoctorService doctorService, IUnityOfWork unityOfWork)
        {
            _doctorService = doctorService;
            _unityOfWork = unityOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _doctorService.GetAllByNonDeleteAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        public async Task<IActionResult> DeletedTable()
        {
            var result = await _doctorService.GetAllByDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.Departments = await _unityOfWork.Department.GetAllAsync(x => x.IsDeleted == false);
            ViewBag.Professions = await _unityOfWork.Profession.GetAllAsync(x => x.IsDeleted == false);

            var result = await _doctorService.GetAsync(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return NotFound();
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await _unityOfWork.Department.GetAllAsync(x => x.IsDeleted == false);
            ViewBag.Professions = await _unityOfWork.Profession.GetAllAsync(x => x.IsDeleted == false);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DoctorPostDto doctorPost)
        {
            ViewBag.Departments = await _unityOfWork.Department.GetAllAsync(x => x.IsDeleted == false);
            ViewBag.Professions = await _unityOfWork.Profession.GetAllAsync(x => x.IsDeleted == false);

            if (ModelState.IsValid)
            {
                var result = await _doctorService.AddAsync(doctorPost);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }

            return View(doctorPost);
        }

        public async Task<IActionResult> Update(int id)
        {
            ViewBag.Departments = await _unityOfWork.Department.GetAllAsync(x => x.IsDeleted == false);
            ViewBag.Professions = await _unityOfWork.Profession.GetAllAsync(x => x.IsDeleted == false);

            var result = await _doctorService.GetUpdateDto(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(DoctorUpdateDto doctorUpdate)
        {
            ViewBag.Departments = await _unityOfWork.Department.GetAllAsync(x => x.IsDeleted == false);
            ViewBag.Professions = await _unityOfWork.Profession.GetAllAsync(x => x.IsDeleted == false);

            if (!ModelState.IsValid)
            {
                var result = await _doctorService.Update(doctorUpdate);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }

            return View(doctorUpdate);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _doctorService.Delete(id);
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
            var result = await _doctorService.HardDelete(id);
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
            var result = await _doctorService.Restore(id);
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
