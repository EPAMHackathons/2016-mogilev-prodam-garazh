using Contracts.Entities;
using DataAccess.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class EventContext : DbContext
	{
		public EventContext()
			: base("ConnectionString")
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<EventContext, Configurations>("ConnectionString"));
		}

		public DbSet<Post> Posts { get; set; }

		public DbSet<Story> Stories { get; set; }

		public DbSet<User> Users { get; set; }

		public DbSet<Tag> Tags { get; set; }

		public DbSet<PostTag> PostsTags { get; set; }

		public DbSet<Content> ContentCollection { get; set; }

	}
}
