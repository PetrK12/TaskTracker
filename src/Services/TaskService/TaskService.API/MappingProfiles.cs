using System;
using AutoMapper;
using TaskService.Infrastructure.Model;

namespace TaskService.API
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<ApplicationUser, UserDto>().ReverseMap();
			CreateMap<ApplicationUser, LoginUserDto>().ReverseMap();
		}
	}
}

