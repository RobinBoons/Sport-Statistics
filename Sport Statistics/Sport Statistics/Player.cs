using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    [Serializable]
    public class Player
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        public Sport Sport { get; private set; }
        

        public Player(string name, int number, Sport sport)
        {
            if(name == null)
            {
                throw new ArgumentNullException();
            }
            
            if(number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(sport == null)
            {
                throw new ArgumentNullException();
            }

            Name = name;
            Number = number;
            Sport = sport;
        }

        public override string ToString()
        {
            return Name + ", " + Number;
        }
    }
}
