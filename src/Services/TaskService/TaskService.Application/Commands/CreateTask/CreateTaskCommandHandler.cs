using System;
using AutoMapper;
using MediatR;
using TaskService.Domain.DomainModel;
using TaskService.Domain.Interfaces;

namespace TaskService.Application.Commands.CreateTask
{
	public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, bool>
	{
        private readonly IEntryRepository _entryRepository;
        private readonly IMapper _mapper;

		public CreateTaskCommandHandler(IEntryRepository entryRepository, IMapper mapper)
		{
            _entryRepository = entryRepository;
            _mapper = mapper;
		}
        
        public async Task<bool> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            return await _entryRepository.CreateTaskAsync(_mapper.Map<Entry>(request));
        }
        
    }
}

