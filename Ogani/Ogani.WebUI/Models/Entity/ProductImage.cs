﻿using System;
namespace Ogani.WebUI.Models.Entity
{
	public class ProductImage
	{
		public int Id { get; set; }
		 
		public string ImagePath { get; set; }

		public bool IsMain { get; set; }

		public int ProductId { get; set; }

		public virtual Product Product { get; set; }
    }
}

