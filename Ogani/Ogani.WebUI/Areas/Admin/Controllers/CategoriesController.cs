using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        readonly OganiDbContext db;

        public CategoriesController(OganiDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await db.Categories
                .Where(c => c.DeletedDate == null)
                .ToListAsync();
            ViewBag.ToastrMsg = TempData["ToastrMsg"];
            return View(categories);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await db.Categories
                .FirstOrDefaultAsync(c => c.Id == id && c.DeletedDate == null);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Add(category);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await db.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(category);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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

        // istifade etmirik, sadece numune kimi saxladim:

        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var category = await db.Categories
        //        .FirstOrDefaultAsync(c => c.Id == id && c.DeletedDate == null);

        //    if (category == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(category);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken] // --> heleki legv edirik bize mane olmasin
        public async Task<IActionResult> Delete(int id)
        {
            if (id<=0)
            {
                return Json(new
                {
                    error = true,
                    message = "Xetali muraciet"
                });
            }

            var category = await db.Categories.FindAsync(id);

            if (category == null)
            {

                return Json(new
                {
                    error = true,
                    message = "Cari qeyd movcud deyil"
                }); 
            }

            category.DeletedDate = DateTime.Now;

            await db.SaveChangesAsync();

            return Json(new
            {
                error = false,
                message = $"{category.Name}* sistemden silindi!"
            });
        }

        [HttpPost]
        public IActionResult ShowToastr( string toastrMsg)
        {
            TempData["ToastrMsg"] = toastrMsg;

            return RedirectToAction(nameof(Index));
        }


        private bool CategoryExists(int id)
        {
            return db.Categories.Any(e => e.Id == id && e.DeletedDate == null);
        }

    }
}

