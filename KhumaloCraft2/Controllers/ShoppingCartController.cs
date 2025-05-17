using KhumaloCraft2.Data;
using KhumaloCraft2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using NuGet.Configuration;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private  List<ShoppingCartItem> _cartItems;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
            _cartItems = new List<ShoppingCartItem>();
        }
        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult AddToCart(int Id)
        {
            var artWorkToAdd = _context.ArtWorks.Find(Id);

            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();


            var existingCartItem = cartItems.FirstOrDefault(item => item.ArtWork.Id == Id);

            if(existingCartItem != null)
            {
                existingCartItem.Total++;

            }
            else
            {
                cartItems.Add(new ShoppingCartItem
                {
                    ArtWork = artWorkToAdd,
                    Total = 1
                }); 
            }

            HttpContext.Session.Set("Cart", cartItems);

            TempData["CartMessage"] = $"{artWorkToAdd.ProdName}  {artWorkToAdd.Type} added to cart"; //writing Temp data

            return RedirectToAction("ViewCart");
        }
      
        public IActionResult ViewCart()
        {
            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            var cartViewModel = new ShoppingCartViewModel
            {
                CartItems = cartItems,
                TotalPrice = cartItems.Sum(item => item.ArtWork.Price * item.Total),
            };

            ViewBag.CartMessage = TempData["CartMessage"]; //Reading TempData

            return View(cartViewModel);
        }

        public IActionResult RemoveItem(int Id)
        {
            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart")?? new List<ShoppingCartItem>();
            var itemToRemove = cartItems.FirstOrDefault(item => item.ArtWork.Id == Id);

            if(itemToRemove != null)
            {
               if(itemToRemove.Total > 1)
                {
                    itemToRemove.Total--;
                }
                else
                {
                    cartItems.Remove(itemToRemove);
                }

            }
            HttpContext.Session.Set("Cart", cartItems);

            return RedirectToAction("ViewCart");
        }

     
        public IActionResult PurchaseItems() 
        {
            var cartItems = HttpContext.Session.Get<List<ShoppingCartItem>>("Cart") ?? new List<ShoppingCartItem>();

            foreach (var item in cartItems)
            {
                //save each item as a purchase
                _context.Purchases.Add(new Models.Purchase
                {
                    ArtWorkId = item.ArtWork.Id,
                    Quantity = item.Total,
                    PurchaseDate = DateTime.Now,
                    Total = item.ArtWork.Price * item.Total,
                });

            }
            //save changes to the database
            _context.SaveChanges();
            //clear the cart
            HttpContext.Session.Set("Cart", new List<ShoppingCartItem>());

            return RedirectToAction("Index", "Home");
        }
    }
}

//Reference List:
//Microsoft.[n.d]. Role-based authorization in ASP.NET Core, [n.d]. [Online]. Available at: Role-based authorization in ASP.NET Core | Microsoft Learn
// [Accessed 07 May 2024].

//Microsoft.[n.d]. Sopping Cart [n.d]. [Online]. Available at: Shopping Cart | Microsoft Learn
// [Accessed 20 May 2024].

//Asp .net core | Role based authorization in asp.net core mvc 7. 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/xhCstGA9WVI?si=vDmAAibZi9YTWLYN [Accessed 22 May 2024].

//ASP.NET Core MVC Tutorial – Build a Website Shopping cart. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/PwQyRQuEor0?si=3et8vPiidJnFwz9-  [Accessed 23 May 2024].

//W3Schhols. [n.d.]. HTML, [n.d.]. [Online]. Available at: HTML Tutorial (w3schools.com) [Accessed 243May 2024].

//ASP.NET Core MVC Tutorial – Build a Shop with Admin Area. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/T9d90fcYJvM?si=9ZJeS_qDzq8UlW_o  [Accessed 25 May 2024].

//Shopping Cart project in .net core mvc (with authentication). 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/JPFlSXejgKc?si=VXSsHSydovhZY3TA  [Accessed 22 May 2024].
//Microsoft.[n.d]. Role-based authorization in ASP.NET Core, [n.d]. [Online]. Available at: Role-based authorization in ASP.NET Core | Microsoft Learn
// [Accessed 07 May 2024].

//Microsoft.[n.d]. Sopping Cart [n.d]. [Online]. Available at: Shopping Cart | Microsoft Learn
// [Accessed 20 May 2024].

//Asp .net core | Role based authorization in asp.net core mvc 7. 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/xhCstGA9WVI?si=vDmAAibZi9YTWLYN [Accessed 22 May 2024].

//ASP.NET Core MVC Tutorial – Build a Website Shopping cart. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/PwQyRQuEor0?si=3et8vPiidJnFwz9-  [Accessed 23 May 2024].

//W3Schhols. [n.d.]. HTML, [n.d.]. [Online]. Available at: HTML Tutorial (w3schools.com) [Accessed 243May 2024].

//ASP.NET Core MVC Tutorial – Build a Shop with Admin Area. 2023. YouTube video added by Evan Gudmestad. [Online]. Available at: https://youtu.be/T9d90fcYJvM?si=9ZJeS_qDzq8UlW_o  [Accessed 25 May 2024].

//Shopping Cart project in .net core mvc (with authentication). 2023. YouTube video added by Ravindra Devrani. [Online]. Available at: https://youtu.be/JPFlSXejgKc?si=VXSsHSydovhZY3TA  [Accessed 22 May 2024].