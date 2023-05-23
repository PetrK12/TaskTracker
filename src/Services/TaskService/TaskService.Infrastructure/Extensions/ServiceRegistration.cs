using System;
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
			services.AddDbContext<EntryContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("TaskConnectionString"),
				b => b.MigrationsAssembly("TaskService.API")));
			return services;
		}
	}
}

