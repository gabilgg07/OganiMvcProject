using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {
        private readonly OganiDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogsController(OganiDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var oganiDbContext = _context.Blogs
                .Include(b => b.Author)
                .Include(b => b.BlogCategory);
            return View(await oganiDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.Author)
                .Include(b => b.BlogCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "FullName");
            ViewData["BlogCategoryId"] = new SelectList(_context.BlogCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Body,ImagePathTemp,Facebook,Twitter,Linkedin,Instagram,AuthorId,BlogCategoryId")] Blog blog)
        {
            if (blog.ImagePathTemp == null)
            {
                ModelState.AddModelError("ImagePathTemp","Sekil gonderilmeyib");
            }

            if (ModelState.IsValid)
            {
                string extension = Path.GetExtension(blog.ImagePathTemp.FileName);
                string pureName = $"{DateTime.Now.ToString("yyMMddhhmmss")}-{Guid.NewGuid()}{extension}";
                string fullPath = Path.Combine(_env.WebRootPath, "uploads", "images", "blogs", pureName);

                using(var stream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                {
                    blog.ImagePathTemp.CopyTo(stream);
                }

                blog.ImagePath = pureName;

                _context.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "FullName", blog.AuthorId);
            ViewData["BlogCategoryId"] = new SelectList(_context.BlogCategories, "Id", "Name", blog.BlogCategoryId);
            return View(blog);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "FullName", blog.AuthorId);
            ViewData["BlogCategoryId"] = new SelectList(_context.BlogCategories, "Id", "Naame", blog.BlogCategoryId);
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Body,ImagePath,Facebook,Twitter,Linkedin,Instagram,AuthorId,BlogCategoryId")] Blog blog)
        {
            if (id != blog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(blog.Id))
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
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "FullName", blog.AuthorId);
            ViewData["BlogCategoryId"] = new SelectList(_context.BlogCategories, "Id", "Name", blog.BlogCategoryId);
            return View(blog);
        }

        // GET: Admin/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.Author)
                .Include(b => b.BlogCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // POST: Admin/Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }
    }
}
