using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ogani.WebUI.Models.Entity
{
	public class Category
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}

