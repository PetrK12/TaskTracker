using System;
using TaskService.Domain.DomainModel;

namespace TaskService.Domain.Interfaces
{
	public interface IEntryRepository
	{
		public Task<bool> CreateTaskAsync(Entry task);

		public Task<bool> UpdateTaskAsync(Entry task);

		public Task<bool> DeleteTaskAsync(Entry task);

		public Task<IEnumerable<Entry>> ListTasksAsync();

		public Task<Entry> GetEntryAsync(int id);
	}
}

