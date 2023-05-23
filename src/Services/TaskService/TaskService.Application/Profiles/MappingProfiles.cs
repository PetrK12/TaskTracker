using System;
using AutoMapper;
using TaskService.Application.Commands;
using TaskService.Domain.DomainModel;

namespace TaskService.Application.Profiles
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<CreateTaskCommand, Entry>().ReverseMap();
		}
	}
}

