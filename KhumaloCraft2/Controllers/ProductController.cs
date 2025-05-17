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

    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Product
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["CatId"] = new SelectList(_context.Set<Category>(), "CatId", "CatId");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,ProdName,Artist,Price,Description,CatId,ImageFileName,Quantity,Details")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CatId"] = new SelectList(_context.Set<Category>(), "CatId", "CatId", product.CatId);
            return View(product);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CatId"] = new SelectList(_context.Set<Category>(), "CatId", "CatId", product.CatId);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,ProdName,Artist,Price,Description,CatId,ImageFileName,Quantity,Details")] Product product)
        {
            if (id != product.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.id))
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
            ViewData["CatId"] = new SelectList(_context.Set<Category>(), "CatId", "CatId", product.CatId);
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.id == id);
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