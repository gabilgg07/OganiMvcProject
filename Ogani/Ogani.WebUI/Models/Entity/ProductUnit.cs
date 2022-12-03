using System;
using System.Collections.Generic;

namespace Ogani.WebUI.Models.Entity
{
	public class ProductUnit
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public virtual ICollection<Product> Products { get; set; }

    }
}

