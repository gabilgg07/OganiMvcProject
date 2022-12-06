using System;
namespace Ogani.WebUI.Models.Entity
{
	public class BlogTagBlog
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }

        public int BlogTagId { get; set; }

        public virtual BlogTag BlogTag { get; set; }

    }
}

