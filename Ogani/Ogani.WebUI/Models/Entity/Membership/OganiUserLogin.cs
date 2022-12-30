using System;
using Microsoft.AspNetCore.Identity;

namespace Ogani.WebUI.Models.Entity.Membership
{
	public class OganiUserLogin:IdentityUserLogin<int>
	{
		public OganiUserLogin()
		{
		}
	}
}

