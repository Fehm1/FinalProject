using Core.Entity.Concrete;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Entities.Concrete;
using MedicativeMVC.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MedicativeMVC.ViewComponents
{
    public class BasketViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BasketViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            List<CheckoutViewModel> checkoutItems = new List<CheckoutViewModel>();
            CheckoutViewModel checkoutItem = null;
            BasketItemViewModel basketItem = null;
            AppUser member = null;
            string basketItemsStr = null;

            if (User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }

            basketItemsStr = HttpContext.Request.Cookies["Basket"];
            if (member == null)
            {
                if (basketItemsStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                    foreach (BasketItemViewModel item in basketItems)
                    {
                        checkoutItem = new CheckoutViewModel
                        {
                            Product = await _context.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == item.ProductId && x.IsDeleted == false),
                            Count = item.Count,
                        };

                        checkoutItems.Add(checkoutItem);
                    }
                }
            }
            else
            {
                List<BasketItem> userBasket = await _context.BasketItems.Include(x => x.Product).Where(x => x.UserId == member.Id && x.IsDeleted == false).ToListAsync();

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

            return View(checkoutItems);
        } 
    }
}
