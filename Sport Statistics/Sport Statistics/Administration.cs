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

        public bool SafeToFile(string fileName) //Filesystem animalshelter
        {
            if (fileName != null)
            {
                if(fileName.Contains("."))
                {
                    string[] sFileName = fileName.Split('.');
                    if(sFileName.Count() == 2 || sFileName[1].Length >= 3 || sFileName[1].Length <= 4)
                    {
                        fileName = sFileName[0];
                    }
                }
                string file = fileName + ".plyr";
                using (Stream FileStream = File.Open(file, FileMode.Create))
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(FileStream, Players);
                    FileStream.Close();
                }
                file = fileName + ".team";
                using (Stream FileStream = File.Open(file, FileMode.Create))
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(FileStream, Teams);
                    FileStream.Close();
                }
                return true;
            }
            return false;
        }

        public bool LoadFromFile(string fileName) 
        {
            if (fileName != null)
            {
                if (fileName.Contains(".plyr"))
                {
                    using (Stream fileStream = File.Open(fileName, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        Teams = (List<Team>)bin.Deserialize(fileStream);
                        fileStream.Close();
                    }
                    return true;
                }
                if (fileName.Contains(".team"))
                {
                    using (Stream fileStream = File.Open(fileName, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        Players = (List<Player>)bin.Deserialize(fileStream);
                        fileStream.Close();
                    }
                    return true;
                }
            }
            return false;
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
            
            return false;
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
    }
}
