using System;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TaskService.Domain.Interfaces;
using TaskService.Infrastructure.Repositories;

namespace TaskService.Application.Extensions
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
			services.AddScoped<IEntryRepository, EntryRepository>();
            return services;
		}
	}
}

