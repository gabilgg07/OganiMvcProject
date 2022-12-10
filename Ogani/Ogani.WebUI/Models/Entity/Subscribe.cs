using System;
using System.ComponentModel.DataAnnotations;

namespace Ogani.WebUI.Models.Entity
{
	public class Subscribe
	{
		public int Id { get; set; }

		[Required]
		public string Email { get; set; }

		[Required]
		public DateTime CreatedDate { get; set; } = DateTime.Now;

		public DateTime? ConfirmedDate { get; set; }
    }
}