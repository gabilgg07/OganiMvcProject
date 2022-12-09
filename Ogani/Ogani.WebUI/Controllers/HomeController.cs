using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ogani.WebUI.AppCode.Extensions;
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
            if (!email.IsEmail())
            {
                return Json(new
                {
                    error = true,
                    message = $"'{email}' - email formati ucun uygun deyil!"
                });
            }

            var founded = db.Subscribes.FirstOrDefault(s => s.Email.Equals(email));

            if (founded != null)
            {

                return Json(new
                {
                    error = false,
                    message = $"'{email}' - email artiq qeydiyatdan kecib"
                });
            }

            var subscribe = new Subscribe
            {
                Email = email
            };

            db.Subscribes.Add(subscribe);

            db.SaveChanges();

            string token = $"{subscribe.Id}-{subscribe.Email}";

            var callbackUrl = Url.Action("ConfirmSubscribe", "Home", new
            {
                token = token
            }, protocol: Request.Scheme);

            var sendState = email.SendEmail($"Zehmet olmasa abunelik isteyinizi <a href='{callbackUrl.ToString()}'>testiq edin!</a>");

            if (!sendState)
            {
                db.Subscribes.Remove(subscribe);
                db.SaveChanges();

                return Json(new
                {
                    error = true,
                    message = $"Muveqqeti olaraq xidmet islemir. Zehmet olmasa biraz sonra yeniden cehd edin"
                });
            }


            var anonymousObj = new
            {
                error = false,
                message = "Siz yeniliklere abune olma sorgusu gonderdiniz, " +
                "E-poct unvaniniza gonderilen linki testiqlemekle emeliyyati tamamlaya bilersiniz",
                email = email
            };

            return Json(anonymousObj);
        }

        public IActionResult ConfirmSubscribe(string token)
        {
            return Json(token);
        }
    }
}

