using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public class Game
    {
        public Team thuis { get; }
        public Team uit { get; }

        List<string> GameLog = new List<string>();
    }
}
