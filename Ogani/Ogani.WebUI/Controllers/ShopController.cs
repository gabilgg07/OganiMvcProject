using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;
using Ogani.WebUI.Models.ViewModel;

namespace Ogani.WebUI.Controllers
{
    public class ShopController : Controller
    {
        readonly OganiDbContext db;

        public ShopController(OganiDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(int pageIndex = 1, int pageSize = 3)
        {
            // lazy loading
            //List<Product> products = db.Products.ToList();

            //List<Product> products = db.Products
            //    .Include(p => p.Images)
            //    .Skip((pageIndex-1)*pageSize)
            //    .Take(pageSize)
            //    .ToList();

            var query = db.Products
                .Include(p => p.Images)
                .AsQueryable();

            var pagedModel = new PagedViewModel<Product>(query, pageIndex, pageSize);

            return View(pagedModel);
        }

        public IActionResult Details(int id)
        {
            var product = db.Products
                .Include(p => p.Images)
                .Include(p => p.Unit)
                .FirstOrDefault(p => p.Id == id);

            return View(product);
        }

        public IActionResult ShoppingCard()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}

