using System;
using Microsoft.EntityFrameworkCore;
using TaskService.Domain.DomainModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TaskService.Infrastructure.Model;
using Entry = TaskService.Domain.DomainModel.Entry;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace TaskService.Infrastructure.AppDbContext
{
	public class EntryContext : IdentityDbContext<ApplicationUser>
	{
		public EntryContext(DbContextOptions<EntryContext> options)
			: base(options)
		{

		}
        public DbSet<Entry> entries { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
		}

    }
}

