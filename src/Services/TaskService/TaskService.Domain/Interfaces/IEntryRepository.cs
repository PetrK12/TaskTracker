using System;
using TaskService.Domain.DomainModel;

namespace TaskService.Domain.Interfaces
{
	public interface IEntryRepository
	{
		public Task<bool> CreateTask(Entry task);

		public Task<bool> UpdateTask(Entry task);

		public Task<bool> DeleteTask(Entry task);

		public Task<IEnumerable<Entry>> ListTasks();

		public Task<Entry> GetEntry(int id);
	}
}

