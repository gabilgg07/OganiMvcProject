﻿using System;
using Microsoft.AspNetCore.Identity;

namespace Ogani.WebUI.Models.Entity.Membership
{
	public class OganiUserClaim:IdentityUserClaim<int>
	{
		public OganiUserClaim()
		{
		}
	}
}

