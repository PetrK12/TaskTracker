using System;
using AutoMapper;
using MediatR;
using TaskService.Domain.DomainModel;
using TaskService.Domain.Interfaces;

namespace TaskService.Application.Queries
{
	public class ListTaskQueryHandler : IRequestHandler<ListTaskQuery, IEnumerable<Entry>>
	{
        private readonly IEntryRepository _repository;
        private readonly IMapper _mapper;

		public ListTaskQueryHandler(IEntryRepository repository, IMapper mapper)
		{
            _repository = repository;
            _mapper = mapper;
		}

        public Task<IEnumerable<Entry>> Handle(ListTaskQuery request, CancellationToken cancellationToken)
        {
            var result = Task.Run(() => _repository.ListTasksAsync());
            return result;
        }
    }
}

