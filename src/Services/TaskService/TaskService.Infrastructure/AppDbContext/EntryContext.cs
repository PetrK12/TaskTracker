using System;
using Microsoft.EntityFrameworkCore;
using TaskService.Domain.DomainModel;

namespace TaskService.Infrastructure.AppDbContext
{
	public class EntryContext : DbContext
	{
		public EntryContext(DbContextOptions<EntryContext> options)
			: base(options)
		{

		}
        DbSet<Model.Entry> entries { get; set; }


    }
}

