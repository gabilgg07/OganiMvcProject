using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ogani.WebUI.Models.Entity
{
	public class BlogTag
	{

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<BlogTagBlog> BlogTagBlogs { get; set; }
    }
}

