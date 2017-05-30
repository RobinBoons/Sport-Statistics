using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public class Game
    {
        public Team Thuis { get; set; }
        public Team Uit { get; set; }

        public List<string> GameLog { get; private set; }

        public Game(Team thuis, Team uit)
        {
            GameLog = new List<string>();
            Thuis = thuis;
            Uit = uit;
        }

        public void AddToDatalog(string[] dataArray)
        {
            for(int i = 0; i < dataArray.Count(); i++)
            {
                GameLog.Add(dataArray[i]);
            }
        }

        public override string ToString()
        {
            return Thuis.Name + " - " + Uit.Name;
        }


    }
}
