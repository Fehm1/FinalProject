using Business.Abstract;
using Core.Utilities.Complex_types;
using DataAccessLayer.Abstract;
using Entities.DTOs.ProductDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace MedicativeMVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUnityOfWork _unityOfWork;

        public ProductController(IProductService productService, IUnityOfWork unityOfWork)
        {
            _productService = productService;
            _unityOfWork = unityOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllByNonDeleteAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        public async Task<IActionResult> DeletedTable()
        {
            var result = await _productService.GetAllDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return View();
        }

        public async Task<IActionResult> Detail(int id)
        {
            var result = await _productService.GetAsync(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }

            return NotFound();
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _unityOfWork.Category.GetAllAsync(x => x.IsDeleted == false);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductPostDto productPost)
        {
            ViewBag.Categories = await _unityOfWork.Category.GetAllAsync(x => x.IsDeleted == false);

            if (ModelState.IsValid)
            {
                var result = await _productService.AddAsync(productPost);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }

            return View(productPost);
        }

        public async Task<IActionResult> Update(int id)
        {
            ViewBag.Categories = await _unityOfWork.Category.GetAllAsync(x => x.IsDeleted == false);

            var result = await _productService.GetUpdateDto(id);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdate)
        {
            ViewBag.Categories = await _unityOfWork.Category.GetAllAsync(x => x.IsDeleted == false);

            if (!ModelState.IsValid)
            {
                var result = await _productService.Update(productUpdate);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("index");
                }
            }

            return View(productUpdate);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productService.Delete(id);
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
            var result = await _productService.HardDelete(id);
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
            var result = await _productService.Restore(id);
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
