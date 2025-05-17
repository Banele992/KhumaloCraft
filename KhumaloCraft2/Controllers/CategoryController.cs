using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft2.Data;
using KhumaloCraft2.Models;
using Microsoft.AspNetCore.Authorization;

namespace KhumaloCraft.Controllers
{
    [Authorize(Roles = "Admin, Artist")]

    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Category
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: Category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CatId,CatName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CatId,CatName")] Category category)
        {
            if (id != category.CatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CatId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CatId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CatId == id);
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