using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp.Models
{
	public class Arena
	{
		public int ArenaId { get; set; }
		public string ArenaName { get; set; }

		public int TeamId { get; set; }

		public virtual Team Team { get; set; }
	}
}
