using System;
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskService.Infrastructure.AppDbContext;
using TaskService.Infrastructure.Model;

namespace TaskService.Infrastructure.Extensions
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
		{
			Console.WriteLine(configuration.GetConnectionString("TaskConnectionString"));
			services.AddDbContext<EntryContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("TaskConnectionString"),
				b => b.MigrationsAssembly("TaskService.API")));
			var builder = services.AddIdentityCore<ApplicationUser>(x => {
				x.Password.RequireDigit = true;
				//x.User.AllowedUserNameCharacters
				});
			builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole),services);
			builder.AddEntityFrameworkStores<EntryContext>().AddDefaultTokenProviders();
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			return services;
		}
	}
}

