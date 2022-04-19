using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            string input;
            while ((input=Console.ReadLine())!="END")
            {
                try
                {
                    string[] command = input.Split(";");
                    if (command[0] == "Team")
                    {
                        Team team = new Team(command[1]);
                        teams.Add(team.Name, team);
                    }
                    else if (command[0] == "Add")
                    {
                        if (!teams.ContainsKey(command[1]))
                        {
                            throw new InvalidOperationException($"Team {command[1]} does not exist.");
                        }
                        Player player = new Player(command[2], int.Parse(command[3]), int.Parse(command[4]),
                            int.Parse(command[5]), int.Parse(command[6]), int.Parse(command[7]));
                        teams[command[1]].AddPlayer(player);
                    }
                    else if (command[0] == "Remove")
                    {
                        Team team = teams[command[1]];
                        team.RemovePlayer(command[2]);
                    }
                    else if (command[0] == "Rating")
                    {
                        if (!teams.ContainsKey(command[1]))
                        {
                            throw new InvalidOperationException($"Team {command[1]} does not exist.");
                        }
                        Team team = teams[command[1]];
                        Console.WriteLine($"{command[1]} - {team.Rating}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
        }
    }
}
