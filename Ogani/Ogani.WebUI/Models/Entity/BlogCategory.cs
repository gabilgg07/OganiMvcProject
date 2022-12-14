using System;
using System.Collections.Generic;

namespace Ogani.WebUI.Models.Entity
{
	public class BlogCategory
	{
		public int Id { get; set; }

		public string Name { get; set; }

        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}

