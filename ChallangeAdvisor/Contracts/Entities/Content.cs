using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
	public class Content
	{
		public int Id { get; set; }

		public string Address { get; set; }

		public Enums.ContentType Type { get; set; }
	}
}
