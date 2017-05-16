using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Sport_Statistics
{
    class Administration
    {
        public List<Team> Teams;
        public List<Player> Players;

        public Administration()
        {
            Teams = new List<Team>();
            Players = new List<Player>();
        }


        public bool AddPlayer(Player player)
        {
            if(player == null)
            {
                throw new ArgumentNullException(player.ToString());
            }
            if (FindPlayer(player.Name) == null)
            {
                Players.Add(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddTeam(Team team)
        {
            if(team == null)
            {
                throw new ArgumentNullException(team.ToString());
            }
            if (FindTeam(team.Name) == null)
            {
                Teams.Add(team);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemovePlayer(Player player)
        {
            if(player == null)
            {
                throw new ArgumentNullException(player.ToString());
            }
            if(FindPlayer(player.Name) != null)
            {
                Players.Remove(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveTeam(Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException(team.ToString());
            }
            if(FindTeam(team.Name) != null)
            { 
                Teams.Remove(team);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Player FindPlayer(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(name);
            }
            foreach (Player player in Players)
            {
                if (player.Name == name)
                {
                    return player;
                }
            }
            return null;
        }

        public Team FindTeam(string name)
        {
            if(name == null)
            {
                throw new ArgumentNullException(name);
            }
            foreach (Team team in Teams)
            {
                if (team.Name == name)
                {
                    return team;
                }
            }
            return null;
        }
               

        public bool AddPlayerToTeam(Team team, Player player)
        {
            if (team == null)
            {
                throw new ArgumentNullException(team.ToString());
            }
            if(player == null)
            {
                throw new ArgumentNullException(player.ToString());
            }
                foreach(Player players in team.TeamPlayers)
                {
                    if(player == players)
                    {
                        return false;
                    }
                }
                team.TeamPlayers.Add(player);
                return true;
        }

        public bool RemovePlayerFromTeam(Team team, Player player)
        {
            if (team == null)
            {
                throw new ArgumentNullException(team.ToString());
            }
            if (player == null)
            {
                throw new ArgumentNullException(player.ToString());
            }
            foreach (Player players in team.TeamPlayers)
                {
                    if(players == player)
                    {
                        team.TeamPlayers.Remove(player);
                        return true;
                    }
                }
            
            return false;
        }

        public void TextToData(string inputData)
        {
            if(inputData == null) { throw new ArgumentNullException(inputData); }
            string[] data = inputData.Split('/');
            int count = data.Count<string>();
            for (int i = 0; i < count; i++) //"Team 1", 2, 4 
            {
                string[] message = data[i].Split(',');

            }
        }
    }
}
