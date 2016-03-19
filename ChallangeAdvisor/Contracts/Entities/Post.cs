using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
	public class Post : IEntity
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Text { get; set; }

		public bool Approved { get; set; }

		public string ImageLink { get; set; }

		public User Author { get; set; }

		public double Latitude { get; set; }

		public double Longitude { get; set; }

		public IList<Story> Stories { get; set; }

		public IList<PostTag> PostsTags { get; set; }

	}
}
