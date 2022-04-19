using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private Dictionary<string, Player> players;
        public Team(string name)
        {
            this.Name = name;
            players = new Dictionary<string, Player>();
        }
        public string Name 
        {
            get 
            {
                return this.name;
            }
            private set
            {
                Validator.ThrowInvalidNameException(value, "A name should not be empty.");
                this.name = value;
            } 
        }
        public double Rating 
        { 
            get 
            {
                if (players.Count==0)
                {
                    return 0;
                }
                return Math.Round(players.Values.Average(p => p.AverageSkill));
            } 
        }
        public void AddPlayer(Player player)
        {
            players.Add(player.Name, player);
        }
        public void RemovePlayer(string playername)
        {
            if (!players.ContainsKey(playername))
            {
                throw new InvalidOperationException($"Player {playername} is not in {this.Name} team.");
            }
            players.Remove(playername);
        }
    }
}
