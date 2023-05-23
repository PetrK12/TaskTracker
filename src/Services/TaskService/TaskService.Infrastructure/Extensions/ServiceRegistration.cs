using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskService.Infrastructure.AppDbContext;

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
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			return services;
		}
	}
}

