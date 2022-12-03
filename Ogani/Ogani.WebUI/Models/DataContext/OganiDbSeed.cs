using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Models.DataContext
{
	public static class OganiDbSeed
	{
		internal static IApplicationBuilder Seed(this IApplicationBuilder app)
		{
			using(var scope = app.ApplicationServices.CreateScope())
			{
				var db = scope.ServiceProvider.GetRequiredService<OganiDbContext>();

				db.Database.Migrate();

				InitCategory(db);
			}

			return app;
		}

        private static void InitCategory(OganiDbContext db)
        {
			if (!db.Categories.Any())
            {
                db.Categories.Add(new Category
                {
                    Name = "Fresh Onion"
                });
                db.Categories.Add(new Category
                {
                    Name = "Fresh Berries"
                });
                db.Categories.Add(new Category
                {
                    Name = "Vegetables"
                });
                db.Categories.Add(new Category
                {
                    Name = "Fresh Bananas"
                });
                db.Categories.Add(new Category
                {
                    Name = "Fresh Meat"
                });

                db.SaveChanges();
            }
        }
    }
}

