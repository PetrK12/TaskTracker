using System;
using TaskService.Domain.DomainModel;
using TaskService.Domain.Interfaces;

namespace TaskService.Infrastructure.Repositories
{
    public class EntryRepository : IEntryRepository
    {


        public Task<bool> CreateTask(Entry task)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTask(Entry task)
        {
            throw new NotImplementedException();
        }

        public Task<Entry> GetEntry(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entry>> ListTasks()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTask(Entry task)
        {
            throw new NotImplementedException();
        }
    }
}

