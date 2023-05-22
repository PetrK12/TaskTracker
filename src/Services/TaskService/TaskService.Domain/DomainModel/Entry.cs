using System;
namespace TaskService.Domain.DomainModel
{
	public class Entry
	{
		public string Name;
		public string Description;
		public int Id;
		public DateTime DateCreated;
		public DateTime DueDate;
		public bool IsDone;
		public bool IsOverdue;
		public string Owner;
		public IEnumerable<string> Colaborators;
	}
}

