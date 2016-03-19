using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
	public static class Enums
	{
		public enum CompletionStatus
		{
			Completed,
			Pending,
			Claimed
		}

		public enum ContentType
		{
			Image,
			Video
		}
	}
}
