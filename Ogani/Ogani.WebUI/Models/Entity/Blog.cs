using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ogani.WebUI.Models.Entity
{
	public class Blog
	{
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

        [Required]
		public string Body { get; set; }

        public string ImagePath { get; set; }

        public DateTime? PublishedDate { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Linkedin { get; set; }

        public string Instagram { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public int BlogCategoryId { get; set; }

        public virtual BlogCategory BlogCategory { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<BlogTagBlog> BlogTagBlogs { get; set; }
    }
}

