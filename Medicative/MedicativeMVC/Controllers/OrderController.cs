using DataAccessLayer.Concrete.EntityFramework.Context;
using MedicativeMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Entities.Concrete;
using Core.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MedicativeMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Order(OrderViewModel orderViewModel)
        {
            if (!ModelState.IsValid) return View(orderViewModel);

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            List<CheckoutViewModel> checkoutItems = new List<CheckoutViewModel>();
            List<BasketItem> userBasket = null;
            CheckoutViewModel checkoutItem = null;
            Order order = null;
            OrderItem orderItem = null;
            AppUser member = null;
            string basketItemStr = HttpContext.Request.Cookies["Basket"];
            double totalPrice = 0;

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                member = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            }

            order = new Order
            {
                Name = orderViewModel.Name,
                Surname = orderViewModel.Surname,
                Phone = orderViewModel.Phone,
                Email = orderViewModel.Email,
                Address = orderViewModel.Address,
                City = orderViewModel.City,
                Country = orderViewModel.Country,
                ZipCode = orderViewModel.ZipCode,
                UserId = member?.Id
            };


            if (member == null)
            {
                if (basketItemStr != null)
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemStr);

                    foreach (var item in basketItems)
                    {
                        Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == item.ProductId && x.IsDeleted == false);
                        product.Count = product.Count - item.Count;
                        orderItem = new OrderItem
                        {
                            Product = product,
                            ProductName = product.Name,
                            Price = product.Price,
                            DiscountPercent = product.DiscountPercent,
                            Count = item.Count,
                            Order = order
                        };
                        totalPrice += orderItem.Price * (1 - (orderItem.DiscountPercent) / 100) * item.Count;
                        order.OrderItems.Add(orderItem);
                    }
                }
            }
            else
            {
                userBasket = await _context.BasketItems.Include(x => x.Product).Where(x => x.UserId == member.Id && x.IsDeleted == false).ToListAsync();

                foreach (var item in userBasket)
                {
                    Product product = await _context.Products.FirstOrDefaultAsync(x => x.Id == item.ProductId && x.IsDeleted == false);
                    product.Count = product.Count - item.Count;
                    orderItem = new OrderItem
                    {
                        Product = product,
                        ProductName = product.Name,
                        Price = product.Price,
                        DiscountPercent = product.DiscountPercent,
                        Count = item.Count,
                        Order = order
                    };
                    totalPrice += orderItem.Price * (1 - (orderItem.DiscountPercent) / 100) * item.Count;
                    order.OrderItems.Add(orderItem);
                }
            }

            order.TotalPrice = totalPrice;
            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction("index", "home");
        }
    }
}
