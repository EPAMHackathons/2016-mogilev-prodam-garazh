using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
	public class User : IEntity
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public IList<Story> Stories { get; set; }

	}
}
