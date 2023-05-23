using System;
using Microsoft.Extensions.DependencyInjection;

namespace TaskService.Application.Extensions
{
	public static class ServiceRegistration
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{

			return services;
		}
	}
}

