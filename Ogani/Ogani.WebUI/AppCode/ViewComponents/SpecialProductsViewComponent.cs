using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;

namespace Ogani.WebUI.AppCode.ViewComponents
{
	public class SpecialProductsViewComponent : ViewComponent
    {
		readonly OganiDbContext db;

        public SpecialProductsViewComponent(OganiDbContext db)
		{
			this.db = db;
		}

		public IViewComponentResult Invoke()
		{
			var products = db.Products
				.Include(p => p.Images)
				.OrderByDescending(p => p.Id)
				.Take(9)
				.ToList();

			return View(products);
		}
	}
}

