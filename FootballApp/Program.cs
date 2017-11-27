using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
	class Program
	{
		static void Main(string[] args)
		{
			FootballContext ctx = new FootballContext();
			Console.WriteLine("Enter a Team Name");
			var teamName = Console.ReadLine();
			var aTeam = new Team();
			aTeam.TeamName = teamName;
			ctx.SaveChanges();

			Console.WriteLine("\nEnter Arena's Name");
			var arenaName = Console.ReadLine();
			var anArena = new Arena();
			anArena.ArenaName = arenaName;
			anArena.Team = aTeam;
			ctx.Arenas.Add(anArena);
			ctx.SaveChanges();

			Console.WriteLine("\nEnter Player's Name: ");
			var playerName = Console.ReadLine();
			var aPlayer = new Player();
			aPlayer.Name = playerName;
			aPlayer.Team = aTeam;
			ctx.Players.Add(aPlayer);
			ctx.SaveChanges();

			Console.WriteLine("\n*********************");
		
			foreach (var theteams in ctx.Arenas)
			{
				Console.WriteLine($"{theteams.Team.TeamName} plays on {theteams.ArenaName}");
			}

			Console.WriteLine("\n*********************");

			foreach (var player in ctx.Players)
			{
				Console.WriteLine($"{player.Name} plays for {player.Team.TeamName}"); 
			}

			Console.WriteLine("\n*********************");
			Console.WriteLine("List of Arenas");
			foreach (var arenaList in ctx.Arenas)
			{
				Console.WriteLine(arenaList.ArenaName);
			}

			Console.WriteLine("\n*********************");
			Console.WriteLine("List of Teams");
			foreach (var teamList in ctx.Teams)
			{
				Console.WriteLine(teamList.TeamName);
			}
			Console.ReadLine();
		}
	}
}
