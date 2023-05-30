using System;
using System.Linq;
using AutoMapper;
using TaskService.Domain.DomainModel;
using TaskService.Domain.Interfaces;
using TaskService.Infrastructure.AppDbContext;

namespace TaskService.Infrastructure.Repositories
{
    public class EntryRepository : IEntryRepository
    {
        private readonly EntryContext _context;
        private readonly IMapper _mapper;

        public EntryRepository(EntryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateTaskAsync(Entry task)
        {
            var entity = await _context.AddAsync(_mapper.Map<Model.Entry>(task));
            //await _context.SaveChangesAsync();
            _context.SaveChanges();
            return entity == null;
        }

        public Task<bool> DeleteTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Entry> GetEntryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entry> ListTasksAsync()
        {
            return (IEnumerable<Entry>)_context.entries.ToList();
        }

        public Task<bool> UpdateTaskAsync(Entry task)
        {
            throw new NotImplementedException();
        }
    }
}

