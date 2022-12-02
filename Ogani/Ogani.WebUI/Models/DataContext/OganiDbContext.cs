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
	}
}

