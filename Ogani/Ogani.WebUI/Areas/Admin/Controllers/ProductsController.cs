using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;
using Ogani.WebUI.Models.ViewModel;

namespace Ogani.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly OganiDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductsController(OganiDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var oganiDbContext = _context.Products
                .Where(p => p.DeletedDate == null)
                .Include(p => p.Category)
                .Include(p => p.Images)
                .Include(p => p.Unit);
            ViewBag.ToastrMsg = TempData["ToastrMsg"];
            return View(await oganiDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Unit)
                .FirstOrDefaultAsync(m => m.Id == id && m.DeletedDate == null);
            if (product == null)
            {
                return NotFound();
            }


            ViewData["Images"] = await _context.ProductImages.Where(pi => pi.ProductId == product.Id).ToListAsync();

            return View(product);
        }

        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["UnitId"] = new SelectList(_context.ProductUnits, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,ShortDescription,Weight,UnitId,CategoryId,Description,Information,Reviews")] Product product,
            ImageItem[] files)
        {
            if (ModelState.IsValid)
            {
                if (files != null)
                {
                    product.Images = new List<ProductImage>();
                    foreach (var item in files)
                    {

                        string extension = Path.GetExtension(item.File.FileName);
                        string pureName = $"{DateTime.Now.ToString("yyMMddHHmmssfff")}-{Guid.NewGuid()}{extension}";
                        string fullPath = Path.Combine(_env.WebRootPath, "uploads", "images", "products", pureName);

                        using (var stream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                        {
                            item.File.CopyTo(stream);
                        }


                        var proImg = new ProductImage
                        {
                            ImagePath = pureName,
                            IsMain = item.IsMain,
                            Product = product
                        };
                        product.Images.Add(proImg);
                    }
                }
                _context.Add(product);

                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception)
                {
                    foreach (var item in product.Images)
                    {
                        string fullPath = Path.Combine(_env.WebRootPath, "uploads", "images", "products", item.ImagePath);

                        if (System.IO.File.Exists(fullPath))
                            System.IO.File.Delete(fullPath);
                    }
                }
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["UnitId"] = new SelectList(_context.ProductUnits, "Id", "Name", product.UnitId);
            return View(product);
        }

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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["UnitId"] = new SelectList(_context.ProductUnits, "Id", "Name", product.UnitId);
            ViewData["Images"] = await _context.ProductImages
                .Where(pi => pi.ProductId == product.Id).ToListAsync();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,ShortDescription,Weight,UnitId,CategoryId,Description,Information,Reviews")] Product product, ImageItem[] files)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            var entity = await _context.Products.Include(p => p.Images)
                .FirstOrDefaultAsync(p => p.Id == id && p.DeletedDate == null);

            if (entity == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                if (files != null)
                {
                    if (entity.Images == null)
                    {
                        entity.Images = new List<ProductImage>();
                    }
                    else if (entity.Images.Count() > 0)
                    {
                        foreach (var item in files)
                        {
                            if (entity.Images.Any(i => i.Id == item?.Id && string.IsNullOrWhiteSpace(item.TempPath)))
                            {
                                var deletedImg = entity.Images.FirstOrDefault(i => i.Id == item.Id);

                                StringBuilder fullP = new StringBuilder();

                                fullP.Append(Path.Combine(_env.WebRootPath,
                               "uploads",
                               "images",
                               "products"));

                                fullP.Append("/" + deletedImg.ImagePath);

                                string fullPath = fullP.ToString();

                                if (System.IO.File.Exists(fullPath))
                                    System.IO.File.Delete(fullPath);

                                entity.Images.Remove(deletedImg);
                            }
                        }
                    }

                    foreach (var item in files)
                    {
                        if (item.Id != null)
                        {
                            continue;
                        }
                        string extension = Path.GetExtension(item.File.FileName);
                        string pureName = $"{DateTime.Now.ToString("yyMMddHHmmssfff")}-{Guid.NewGuid()}{extension}";
                        string fullPath = Path.Combine(_env.WebRootPath, "uploads", "images", "products", pureName);

                        using (var stream = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                        {
                            item.File.CopyTo(stream);
                        }

                        var proImg = new ProductImage
                        {
                            ImagePath = pureName,
                            IsMain = item.IsMain,
                            Product = entity
                        };
                        entity.Images.Add(proImg);
                    }
                }

                entity.Name = product.Name;
                entity.CategoryId = product.CategoryId;
                entity.UnitId = product.UnitId;
                entity.Price = product.Price;
                entity.ShortDescription = product.ShortDescription;
                entity.Weight = product.Weight;
                entity.Description = product.Description;
                entity.Information = product.Information;
                entity.Reviews = product.Reviews;
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", product.CategoryId);
            ViewData["UnitId"] = new SelectList(_context.ProductUnits, "Id", "Name", product.UnitId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Unit)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
