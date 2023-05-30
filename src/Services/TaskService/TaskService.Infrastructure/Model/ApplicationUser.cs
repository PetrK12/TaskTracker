using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace TaskService.Infrastructure.Model
{
	public class ApplicationUser: IdentityUser
	{
        public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}

