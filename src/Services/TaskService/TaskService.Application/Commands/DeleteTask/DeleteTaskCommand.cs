using System;
using MediatR;

namespace TaskService.Application.Commands.DeleteTask
{
	public class DeleteTaskCommand : IRequest<bool>
	{
		public int Id { get; set; }

		public DeleteTaskCommand(int id)
		{
			Id = id;
		}
	}
}

