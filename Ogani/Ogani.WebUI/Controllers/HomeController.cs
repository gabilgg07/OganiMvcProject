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
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactPost cPost)
        {
            if (ModelState.IsValid)
            {
                db.ContactPosts.Add(cPost);
                db.SaveChanges();

                TempData["PostMessage"] = "Sualınız müvəffəqiyyətlə göndərildi";

                return RedirectToAction(nameof(Contact));
            }

            return View(cPost);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Subscribe(string email)
        {
            var anonymousObj = new
            {
                error = false,
                message = "Siz yeniliklere abune olma sorgusu gonderdiniz," +
                "E-poct unvaniniza gonderilen linki testiqlemekle emeliyyati tamamlaya bilersiniz",
                email = email
            };

            return Json(anonymousObj);
        }
    }
}

