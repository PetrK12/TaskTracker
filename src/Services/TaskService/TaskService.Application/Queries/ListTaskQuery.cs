using System;
using MediatR;
using TaskService.Domain.DomainModel;

namespace TaskService.Application.Queries
{
	public class ListTaskQuery : IRequest<IEnumerable<Entry>>
	{

	}
}

