using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
	public class PostTag
	{
		public int Id { get; set; }
		public IList<Tag> Tags { get; set; }

		public IList<Post> Posts { get; set; }
	}
}
