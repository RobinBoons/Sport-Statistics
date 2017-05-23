using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public class Handball : Sport
    {
        public int TimePenaltys { get; set; }
        public int Yellowcards { get; set; }
        public int Exclusions { get; set; }
        public int Breakouts { get; set; }

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
            return "%, " + TimePenaltys
                                   + ", " + Yellowcards
                                   + ", " + Exclusions
                                   + ", " + Breakouts;
        }

        public override void addStatics(int propName)
        {
            switch(propName)
            {
                case 3: TimePenaltys++;
                    break;
                case 4: Yellowcards++;
                    break;
                case 5: Exclusions++;
                    break;
                case 6: Breakouts++;
                    break;
            }
        }

    }
}
