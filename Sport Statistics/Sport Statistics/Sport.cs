using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public class Sport
    {
        public int Score { get; private set; }
        public int Attempts { get; private set; }
        public decimal ScorePercentage { get; private set; }

        public Sport()
        {

        }

        public void CalculatePercentage()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
