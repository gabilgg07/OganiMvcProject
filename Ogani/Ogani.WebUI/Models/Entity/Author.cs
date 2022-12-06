using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ogani.WebUI.Models.Entity
{
	public class Author
	{
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
        public string Role { get; set; }
        public string ImagePath { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}

