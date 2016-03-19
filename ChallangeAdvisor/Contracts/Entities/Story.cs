using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
	public class Story : IEntity
	{
		public int Id { get; set; }

		public string StoryText { get; set; }

		public User User { get; set; }

		public Post Post { get; set; }

		public bool Approved { get; set; }

		public Enums.CompletionStatus CompletionStatus { get; set; }

		public IList<Content> ContentCollection { get; set; }
	}
}
