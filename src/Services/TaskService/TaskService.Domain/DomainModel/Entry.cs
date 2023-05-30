using System;
using System.ComponentModel.DataAnnotations;

namespace TaskService.Domain.DomainModel
{
	public class Entry
	{
		[Key]
        public int Id { get; set; }
        public string Name;
		public string Description;
		public DateTime DateCreated;
		public DateTime DueDate;
		public bool IsDone;
		public bool IsOverdue;
		public string Owner;
		public IEnumerable<string> Colaborators;
	}
}

