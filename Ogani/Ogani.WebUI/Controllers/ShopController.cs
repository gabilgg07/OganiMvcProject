using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Controllers
{
    public class ShopController : Controller
    {
        readonly OganiDbContext db;

        public ShopController(OganiDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            // lazy loading
            //List<Product> products = db.Products.ToList();
            List<Product> products = db.Products
                .Include(p => p.Images)
                .ToList();

            return View(products);
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

