using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    [Serializable]
    public class Team
    {
        public string Name { get; private set; }
        public string Club { get; private set; }
        public Sport Sport { get; private set; }
        public List<Player> TeamPlayers { get; set; }

        public Team(string name, string club, Sport sport)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }

            if (club == null)
            {
                throw new ArgumentNullException();
            }

            if (sport == null)
            {
                throw new ArgumentNullException();
            }
            TeamPlayers = new List<Player>();
            Name = name;
            Club = club;
            Sport = sport;
        }

        public override string ToString()
        {
            return Name + ", " + Club;
        }
    }
}
