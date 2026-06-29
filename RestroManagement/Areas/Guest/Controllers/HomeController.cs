using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestroManagement.ViewModels;
using System;

namespace RestroManagement.Areas.Guest.Controllers
{
    [Area("Guest")]
    public class HomeController : Controller
    {
        private readonly AppDBContext dBContext;

        public HomeController(AppDBContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Menu()
        {
            var items = await dBContext.Fooditems
                .Include(f => f.Categories)
                    .ThenInclude(fc => fc.Category)
                .Include(f => f.Images)
                .Include(f => f.Portions)
                .ToListAsync();
            return View(items);
        }

        [HttpPost]
        public IActionResult AddMultipleToCart(
            List<int> FoodItemId, 
            List<string> ItemName, 
            List<string> PortionName, 
            List<double> Price, 
            List<int> Quantity)
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = string.IsNullOrEmpty(cartJson)
                ? new List<CartItem>()
                : JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();

            if (FoodItemId != null)
            {
                for (int i = 0; i < FoodItemId.Count; i++)
                {
                    if (Quantity[i] > 0)
                    {
                        var existingItem = cart.FirstOrDefault(item => 
                            item.FoodItemId == FoodItemId[i] && 
                            item.PortionName == PortionName[i]);

                        if (existingItem != null)
                        {
                            existingItem.Quantity += Quantity[i];
                            existingItem.Price = Price[i]; // Update price to latest selected
                        }
                        else
                        {
                            cart.Add(new CartItem
                            {
                                FoodItemId = FoodItemId[i],
                                ItemName = ItemName[i],
                                PortionName = PortionName[i],
                                Price = Price[i],
                                Quantity = Quantity[i]
                            });
                        }
                    }
                }
            }

            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
            return RedirectToAction("Cart");
        }

        [HttpPost]
        public IActionResult UpdateCart(
            List<int> FoodItemId, 
            List<string> ItemName, 
            List<string> PortionName, 
            List<double> Price, 
            List<int> Quantity, 
            string submitAction)
        {
            var cart = new List<CartItem>();

            if (FoodItemId != null)
            {
                for (int i = 0; i < FoodItemId.Count; i++)
                {
                    if (Quantity[i] > 0)
                    {
                        cart.Add(new CartItem
                        {
                            FoodItemId = FoodItemId[i],
                            ItemName = ItemName[i],
                            PortionName = PortionName[i],
                            Price = Price[i],
                            Quantity = Quantity[i]
                        });
                    }
                }
            }

            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));

            if (submitAction == "checkout")
            {
                return RedirectToAction("Checkout", "Order");
            }

            return RedirectToAction("Cart");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int FoodItemId, string PortionName)
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            if (!string.IsNullOrEmpty(cartJson))
            {
                var cart = JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();
                var itemToRemove = cart.FirstOrDefault(i => i.FoodItemId == FoodItemId && i.PortionName == PortionName);
                if (itemToRemove != null)
                {
                    cart.Remove(itemToRemove);
                    HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
                }
            }
            return RedirectToAction("Cart");
        }

        public IActionResult Cart()
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = string.IsNullOrEmpty(cartJson)
                ? new List<CartItem>()
                : JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();

            // Populate portion options for editing in cart
            foreach (var item in cart)
            {
                var foodItem = dBContext.Fooditems
                    .Include(f => f.Portions)
                    .FirstOrDefault(f => f.Id == item.FoodItemId);

                if (foodItem?.Portions != null)
                {
                    item.Portions = foodItem.Portions.Select(p => new PortionOption
                    {
                        Name = p.Name,
                        Price = p.Price
                    }).ToList();
                }
            }

            return View(cart);
        }
    }
}
