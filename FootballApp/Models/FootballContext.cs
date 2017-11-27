using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp.Models
{
	class FootballContext : DbContext
	{
		public DbSet<Arena> Arenas { get; set; }
		public DbSet<Team> Teams { get; set; }

		public DbSet<Player> Players { get; set; }
	}
}
