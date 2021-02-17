using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return roster.Count; } }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);

            if (player == null)
            {
                return false;
            }

            roster.Remove(player);
            return true;
        }

        public void PromotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            player.Rank = "Member";
        }

        public void DemotePlayer(string name)
        {
            Player player = roster.FirstOrDefault(p => p.Name == name);
            player.Rank = "Trial";
        }

        public Player[] KickPlayersByClass(string clas)
        {
            Player[] players = roster.Where(p => p.Class == clas).ToArray();

            foreach (var player in players)
            {
                roster.Remove(player);
            }

            return players;
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Players in the guild: {Name}");

            foreach (var player in roster)
            {
                result.AppendLine($"Player {player.Name}: {player.Class}");
                result.AppendLine($"Rank: {player.Rank}");
                result.AppendLine($"Description: {player.Description}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
