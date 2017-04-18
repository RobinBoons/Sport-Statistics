using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public class Handball : Sport
    {
        public int TimePenaltys { get; private set; }
        public int Yellowcards { get; private set; }
        public int Exclusions { get; private set; }
        public int Breakouts { get; private set; }

        public Handball(decimal score, decimal attempts, decimal scorePercentage, int timePenaltys, int yellowCards, int exclusions, int breakouts): base(score, attempts, scorePercentage)
        {
            if (timePenaltys < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (yellowCards < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (exclusions < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (breakouts < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            TimePenaltys = timePenaltys;
            Yellowcards = yellowCards;
            Exclusions = exclusions;
            Breakouts = breakouts;
        }

        public override string ToString()
        {
            return base.ToString() + "%, " + TimePenaltys
                                   + ", " + Yellowcards
                                   + ", " + Exclusions
                                   + ", " + Breakouts;
        }
    }
}
