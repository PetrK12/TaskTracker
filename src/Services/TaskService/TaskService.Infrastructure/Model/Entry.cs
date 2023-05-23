using System;
using Microsoft.EntityFrameworkCore;

namespace TaskService.Infrastructure.Model
{
    public class Entry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsOverdue { get; set; }
        public string Owner { get; set; }
//        public ICollection<string> Colaborators { get; set; }
    }
}

