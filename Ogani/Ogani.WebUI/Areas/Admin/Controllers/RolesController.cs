using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity.Membership;

namespace Ogani.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RolesController : Controller
    {
        private readonly OganiDbContext _context;

        public RolesController(OganiDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Roles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Roles.ToListAsync());
        }

        // GET: Admin/Roles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oganiRole = await _context.Roles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oganiRole == null)
            {
                return NotFound();
            }

            return View(oganiRole);
        }

        // GET: Admin/Roles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Roles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,NormalizedName,ConcurrencyStamp")] OganiRole oganiRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oganiRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oganiRole);
        }

        // GET: Admin/Roles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oganiRole = await _context.Roles.FindAsync(id);
            if (oganiRole == null)
            {
                return NotFound();
            }
            return View(oganiRole);
        }

        // POST: Admin/Roles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,NormalizedName,ConcurrencyStamp")] OganiRole oganiRole)
        {
            if (id != oganiRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oganiRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OganiRoleExists(oganiRole.Id))
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
            return View(oganiRole);
        }

        // GET: Admin/Roles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oganiRole = await _context.Roles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oganiRole == null)
            {
                return NotFound();
            }

            return View(oganiRole);
        }

        // POST: Admin/Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oganiRole = await _context.Roles.FindAsync(id);
            _context.Roles.Remove(oganiRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OganiRoleExists(int id)
        {
            return _context.Roles.Any(e => e.Id == id);
        }
    }
}
