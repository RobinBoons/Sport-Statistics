﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Sport_Statistics
{

    public struct pointI
    {
        int Beat, Time;
        public pointI(int beat, int time)
        {
            Beat = beat;
            Time = time;
        }

    }
    class Administration
    {
        public List<Team> Teams;
        public List<Player> Players;
        public List<Game> Games;

        public Administration()
        {
            Teams = new List<Team>();
            Players = new List<Player>();
            Games = new List<Game>();
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

        public Game FindGame(Game game)
        {
            if (game == null)
            {
                throw new ArgumentNullException(game.ToString());
            }
            foreach (Game fgame in Games)
            {
                if (fgame.Uit == game.Uit && fgame.Thuis == game.Thuis && game.GameLog == fgame.GameLog)
                {
                    return fgame;
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

        public void TextToData(string inputData, Game game)
        {
            if(inputData == null) { throw new ArgumentNullException(inputData); }
            string[] data = inputData.Split('/');
            game.AddToDatalog(data);
            int count = data.Count<string>();
            Team thuis = game.Thuis;
            Team uit = game.Uit;
            Player player = null;
            for (int i = 0; i < count; i++) //Team 1, 2, 4 
            {
                string[] message = data[i].Split(',');
                if(message[0] == "1")
                {
                    int index = Convert.ToInt32(message[1]);
                    player = thuis.TeamPlayers[index];
                }
                else if(message[0] == "2")
                {
                    int index = Convert.ToInt32(message[1]);
                    player = uit.TeamPlayers[index];
                }

                if(player.Sport is Handball)
                {
                    int index = Convert.ToInt32(message[2]);
                    switch(index)
                    {
                        case 1: player.Sport.Score++;
                            break;
                        case 2: player.Sport.Attempts++;
                            break;
                        default: player.Sport.AddStatics(index);
                            break;
                    }
                }
                
                
            }
        }
    }
}
