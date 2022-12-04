﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Ogani.WebUI.Models.Entity
{
	public class ContactPost
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string FullName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public string Answer { get; set; }

		public DateTime? AnswerDate { get; set; }
    }
}
