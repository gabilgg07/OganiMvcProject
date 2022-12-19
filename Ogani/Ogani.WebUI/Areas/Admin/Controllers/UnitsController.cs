using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UnitsController : Controller
    {
        private readonly OganiDbContext _context;

        public UnitsController(OganiDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var units = await _context.ProductUnits
                .Where(u => u.DeletedDate == null)
                .ToListAsync();
            ViewBag.ToastrMsg = TempData["ToastrMsg"];

            return View(units);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUnit = await _context.ProductUnits
                .FirstOrDefaultAsync(m => m.Id == id && m.DeletedDate == null);
            if (productUnit == null)
            {
                return NotFound();
            }

            return View(productUnit);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] ProductUnit productUnit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productUnit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productUnit);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productUnit = await _context.ProductUnits.FindAsync(id);
            if (productUnit == null)
            {
                return NotFound();
            }
            return View(productUnit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] ProductUnit productUnit)
        {
            if (id != productUnit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productUnit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductUnitExists(productUnit.Id))
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
            return View(productUnit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return Json(new
                {
                    error = true,
                    message = "Xetali muraciet"
                });
            }

            var unit = await _context.ProductUnits.FindAsync(id);

            if (unit == null)
            {

                return Json(new
                {
                    error = true,
                    message = "Cari qeyd movcud deyil"
                });
            }

            unit.DeletedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            return Json(new
            {
                error = false,
                message = $"{unit.Name}* sistemden silindi!"
            });
        }


        [HttpPost]
        public IActionResult ShowToastr(string toastrMsg)
        {
            TempData["ToastrMsg"] = toastrMsg;

            return RedirectToAction(nameof(Index));
        }


        private bool ProductUnitExists(int id)
        {
            return _context.ProductUnits.Any(e => e.Id == id);
        }
    }
}
