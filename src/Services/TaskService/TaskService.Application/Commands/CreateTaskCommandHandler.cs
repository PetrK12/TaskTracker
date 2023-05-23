using System;
using MediatR;
using TaskService.Domain.Interfaces;

namespace TaskService.Application.Commands
{
	public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand>
	{
        private readonly IEntryRepository _entryRepository;

		public CreateTaskCommandHandler(IEntryRepository entryRepository)
		{
            entryRepository = entryRepository;
		}

        public Task Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            
        }
    }
}

