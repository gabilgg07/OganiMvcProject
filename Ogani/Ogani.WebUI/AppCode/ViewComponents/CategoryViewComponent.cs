using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Ogani.WebUI.Models.DataContext;

namespace Ogani.WebUI.AppCode.ViewComponents
{
	public class CategoryViewComponent : ViewComponent
	{
		readonly OganiDbContext db;


        public CategoryViewComponent(OganiDbContext db)
		{
			this.db = db;
		}

		public IViewComponentResult Invoke()
		{
			var categories = db.Categories.ToList();

			return View(categories);
		}
	}
}

