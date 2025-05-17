
using KhumaloCraft2.Data;
using KhumaloCraft2.Models;
using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft.Controllers
{
    public class ArtWorkController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ArtWorkController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("ArtWork/List/{category?}")]
        public IActionResult List(string type = "all")
        {
            List<ArtWork> artworks;

            if (type == "all")
            {
                artworks = _context.ArtWorks.ToList();
            }
            else
            {
                artworks = _context.ArtWorks.Where(p => p.Type == type).ToList();
            }
            return View(artworks);
        }


        [Route("ArtWork/Details/{id}/{slug?}")]
        public IActionResult Details(int id)
        {
            var artworks = _context.ArtWorks.Find(id);
            if (artworks != null && artworks.ImageFileName != null)
            {
                artworks.ImageFileName = "/images/" + artworks.ImageFileName;
            }
            return View(artworks);
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
