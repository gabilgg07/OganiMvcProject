using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        public IActionResult Index(int? categoryId,int pageIndex = 1, int pageSize = 3)
        {
            // lazy loading
            //List<Product> products = db.Products.ToList();

            //List<Product> products = db.Products
            //    .Include(p => p.Images)
            //    .Skip((pageIndex-1)*pageSize)
            //    .Take(pageSize)
            //    .ToList();
            var query = db.Products.AsQueryable();

            if (categoryId != null)
            {
                query = query.Where(p => p.CategoryId == categoryId);
            }

            query = query
                .Where(p => p.DeletedDate == null)
                .Include(p => p.Images);

            var pagedModel = new PagedViewModel<Product>(query, pageIndex, pageSize,categoryId);

            return View(pagedModel);
        }

        public IActionResult Details(int id)
        {
            var product = db.Products
                .Include(p => p.Images)
                .Include(p => p.Unit)
                .FirstOrDefault(p => p.Id == id && p.DeletedDate == null);

            return View(product);
        }

        public async Task<IActionResult> ShoppingCard()
        {
            if (Request.Cookies.TryGetValue("basket", out string basketJson))
            {
                var basket = JsonConvert.DeserializeObject<List<BasketItem>>(basketJson);

                foreach (var basketItem in basket)
                {
                    var product = await db.Products
                        .Include(p => p.Images)
                        .FirstOrDefaultAsync(p => p.Id == basketItem.ProductId && p.DeletedDate == null);

                    basketItem.Name = product.Name;
                    basketItem.Price = product.Price;
                    basketItem.ImagePath = product.Images?
                        .FirstOrDefault(i => i.IsMain)?.ImagePath;
                }

                return View(basket);
            }
            return View();
        }

        public async Task<IActionResult> Checkout()
        {
            if (Request.Cookies.TryGetValue("basket", out string basketJson))
            {
                var basket = JsonConvert.DeserializeObject<List<BasketItem>>(basketJson);

                foreach (var basketItem in basket)
                {
                    var product = await db.Products
                        .FirstOrDefaultAsync(p => p.Id == basketItem.ProductId && p.DeletedDate == null);

                    basketItem.Name = product.Name;
                    basketItem.Price = product.Price;
                }

                return View(basket);
            }
            return View();
        }
    }
}

