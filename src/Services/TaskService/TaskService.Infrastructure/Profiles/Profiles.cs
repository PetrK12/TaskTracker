using System;
using AutoMapper;
using TaskService.Domain.DomainModel;

namespace TaskService.Infrastructure.Profiles
{
	public class Profiles : Profile
	{
		public Profiles()
		{
			CreateMap<Model.Entry, Entry>().ReverseMap();
		}
	}
}

