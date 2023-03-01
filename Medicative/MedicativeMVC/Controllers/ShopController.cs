using Core.Entity.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using MedicativeMVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MedicativeMVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ShopController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            ShopViewModel shopViewModel = new ShopViewModel()
            {
                Products = await _context.Products.Include(x => x.Category).Where(x => x.IsDeleted == false).ToListAsync(),
                Settings = await _context.Settings.ToListAsync()
            };

            return View(shopViewModel);
        }


        public async Task<IActionResult> Checkout()
        {
            ViewBag.Settings = await _context.Settings.ToListAsync();

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            List<CheckoutViewModel> checkoutItems = new List<CheckoutViewModel>();
            List<BasketItem> userBasket = null;
            CheckoutViewModel checkoutItem = null;
            AppUser user = null;
            OrderViewModel orderViewModel = null;
            string basketItemStr = HttpContext.Request.Cookies["Basket"];

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }

            if (user == null)
            {
                if (basketItemStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemStr);

                    foreach (var item in basketItems)
                    {
                        checkoutItem = new CheckoutViewModel
                        {
                            Product = await _context.Products.FirstOrDefaultAsync(x => x.Id == item.ProductId),
                            Count = item.Count
                        };

                        checkoutItems.Add(checkoutItem);
                    }
                }
            }
            else
            {
                userBasket = await _context.BasketItems.Include(x => x.Product).Where(x => x.UserId == user.Id && x.IsDeleted == false).ToListAsync();

                foreach (var item in userBasket)
                {
                    checkoutItem = new CheckoutViewModel
                    {
                        Product = item.Product,
                        Count = item.Count
                    };

                    checkoutItems.Add(checkoutItem);
                }
            }

            orderViewModel = new OrderViewModel
            {
                CheckoutItems = checkoutItems
            };

            return View(orderViewModel);
        }

        //public IActionResult Cart()
        //{
        //    return View();
        //}

        public async Task<IActionResult> AddToBasket(int productId)
        {
            if (!_context.Products.Any(x => x.Id == productId)) return NotFound();

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            BasketItemViewModel basketItem = null;
            AppUser user = null;

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }

            string basketItemStr = HttpContext.Request.Cookies["Basket"];

            if (user == null)
            {
                if (basketItemStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemStr);

                    basketItem = basketItems.FirstOrDefault(x => x.ProductId == productId);

                    if (basketItem != null) basketItem.Count++;
                    else
                    {
                        basketItem = new BasketItemViewModel
                        {
                            ProductId = productId,
                            Count = 1
                        };

                        basketItems.Add(basketItem);
                    }
                }
                else
                {
                    basketItem = new BasketItemViewModel
                    {
                        ProductId = productId,
                        Count = 1
                    };
                    basketItems.Add(basketItem);
                }

                basketItemStr = JsonConvert.SerializeObject(basketItems);

                HttpContext.Response.Cookies.Append("Basket", basketItemStr);
            }
            else
            {
                BasketItem memberBasketItem = _context.BasketItems.FirstOrDefault(x => x.IsDeleted == false && x.UserId == user.Id && x.ProductId == productId);

                if (memberBasketItem != null)
                {
                    memberBasketItem.Count++;
                }
                else
                {
                    memberBasketItem = new BasketItem
                    {
                        UserId = user.Id,
                        ProductId = productId,
                        Count = 1
                    };

                    _context.BasketItems.Add(memberBasketItem);
                }
                _context.SaveChanges();
            }

            return Ok();
        }

        public IActionResult GetBasketItem()
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            string basketItemStr = HttpContext.Request.Cookies["Basket"];

            if (basketItemStr != null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemStr);
            }

            return Json(basketItems);
        }


        public async Task<IActionResult> RemoveBasket(int productId)
        {
            List<BasketItemViewModel> basketItems = null;
            BasketItemViewModel basketItem = null;
            AppUser member = null;

            string basketItemsStr = HttpContext.Request.Cookies["Basket"];

            if (User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }


            if (member == null)
            {
                if (basketItemsStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                    basketItem = basketItems.FirstOrDefault(x => x.ProductId == productId);

                    basketItems.Remove(basketItem);
                }
                else
                {
                    return NotFound();
                }

                basketItemsStr = JsonConvert.SerializeObject(basketItems);
                HttpContext.Response.Cookies.Append("Basket", basketItemsStr);
            }
            else
            {
                BasketItem memberBasketItem = await _context.BasketItems.Include(x => x.Product.Category).FirstOrDefaultAsync(x => x.UserId == member.Id && x.ProductId == productId);

                if (memberBasketItem != null)
                {
                    _context.BasketItems.Remove(memberBasketItem);
                }
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}
