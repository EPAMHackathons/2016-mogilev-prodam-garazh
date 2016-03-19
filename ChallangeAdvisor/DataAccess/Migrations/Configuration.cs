using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Migrations
{
	internal sealed class Configurations : DbMigrationsConfiguration<EventContext>
	{
		public Configurations()
		{
			AutomaticMigrationsEnabled = false;
		}
	}
}
