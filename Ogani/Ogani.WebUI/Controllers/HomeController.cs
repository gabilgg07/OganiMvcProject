using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Controllers
{
    public class HomeController : Controller
    {
        readonly OganiDbContext db;

        public HomeController(OganiDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactPost cPost)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(cPost);
                db.SaveChanges();

                return RedirectToAction(nameof(Contact));
            }

            return View(cPost);
        }
    }
}

