using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity;
using Ogani.WebUI.Models.ViewModel;

namespace Ogani.WebUI.Controllers
{
    public class BlogController : Controller
    {
        readonly OganiDbContext db;

        public BlogController(OganiDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(int pageIndex = 1, int pageSize = 6, int? tagId = null)
        {

            var query = db.Blogs.AsQueryable();

            if (tagId != null)
            {
                query = query.Where(b => b.BlogTagBlogs.Any(btb => btb.BlogTagId == tagId));
            }

            query = query
                .Include(b => b.Author)
                .Include(b => b.Comments)
                .AsQueryable();

            var pagedModel = new PagedViewModel<Blog>(query, pageIndex, pageSize, tagId: tagId);

            ViewBag.BlogTags = db.BlogTags.ToList();

            return View(pagedModel);
        }

        public IActionResult Details(int id)
        {
            var blog = db.Blogs
                .Include(b => b.Author)
                .Include(b => b.Comments)
                .Include(b => b.BlogTagBlogs)
                .ThenInclude(bt => bt.BlogTag)
                .FirstOrDefault(b => b.Id == id);

            if (blog == null)
                return NotFound();

            ViewBag.BlogTags = db.BlogTags.ToList();

            return View(blog);
        }
    }
}

