using System;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.Entity;

namespace Ogani.WebUI.Models.DataContext
{
	public class OganiDbContext : DbContext
    {
		public OganiDbContext(DbContextOptions options)
			:base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }

		public DbSet<ProductUnit> ProductUnits { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<ProductImage> ProductImages { get; set; }

		public DbSet<ContactPost> ContactPosts { get; set; }

		public DbSet<AppInfo> AppInfos { get; set; }
    }
}

