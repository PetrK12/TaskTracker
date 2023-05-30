using System;
using MediatR;
using TaskService.Domain.Interfaces;

namespace TaskService.Application.Commands.DeleteTask
{
	public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, bool>
	{
        private readonly IEntryRepository _repository;

		public DeleteTaskCommandHandler(IEntryRepository repository)
		{
            _repository = repository;
		}

        public async Task<bool> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteTaskAsync(request.Id);
        }
    }
}

