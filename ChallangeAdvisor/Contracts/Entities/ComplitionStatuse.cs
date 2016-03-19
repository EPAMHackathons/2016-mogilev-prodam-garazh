using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
	public static class ComplitionStatuse
	{
		public enum Status
		{
			Completed,
			Pending,
			Claimed
		}
	}
}
