using System;
using MediatR;

namespace TaskService.Application.Commands
{
	public class CreateTaskCommand : IRequest
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsOverdue { get; set; }
        public string Owner { get; set; }
    }
}

