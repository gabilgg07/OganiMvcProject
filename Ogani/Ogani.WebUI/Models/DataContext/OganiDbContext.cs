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


		public DbSet<Author> Authors { get; set; }

		public DbSet<User> Users { get; set; }

		public DbSet<BlogTag> BlogTags { get; set; }

		public DbSet<Blog> Blogs { get; set; }

		public DbSet<Comment> Comments { get; set; }

		public DbSet<BlogTagBlog> BlogTagBlogs { get; set; }
    }
}

