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

/*
 
                MimeMessage mailMessage = new MimeMessage();
				mailMessage.From.Add(MailboxAddress.Parse("aaliyeva0790@yandex.com"));
				mailMessage.To.Add(MailboxAddress.Parse(email));
                mailMessage.Subject = subject;
				mailMessage.Body = new TextPart(TextFormat.Html)
				{
					Text = message
				};


				using var smtp = new SmtpClient();
				smtp.Connect("smtp.yandex.com", 587, SecureSocketOptions.StartTls);
				smtp.Authenticate("aaliyeva0790@yandex.com", "1970@veyilA");
				smtp.Send(mailMessage);
				smtp.Disconnect(true);

 */