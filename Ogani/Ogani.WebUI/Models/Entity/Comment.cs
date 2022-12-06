using System;
using System.ComponentModel.DataAnnotations;

namespace Ogani.WebUI.Models.Entity
{
	public class Comment
	{

        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}

