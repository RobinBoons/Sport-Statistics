using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    class Team
    {
        public string Name { get; private set; }
        public string Club { get; private set; }

        public Team(string name, string club)
        {
            if(name == null)
            {
                throw new ArgumentNullException();
            }

            if(club == null)
            {
                throw new ArgumentNullException();
            }

            Name = name;
            Club = club;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
