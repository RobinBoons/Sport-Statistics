using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public class Basketball : Sport
    {
        public decimal FreeThrowMade { get; private set; }
        public decimal FreeThrowAttempts { get; private set; }
        public decimal FreeThrowPercentage { get; private set; }
        public decimal Rebounds { get; private set; }
        public decimal TurnOvers { get; private set; }
        public decimal Fouls { get; private set; }
        public decimal TeamFouls { get; private set; }
        public decimal Steals { get; private set; }
        public decimal Assists { get; private set; }
        public decimal ThreePointeresAttempted { get; private set; }
        public decimal ThreePointersMade { get; private set; }
        public decimal ThreePointersPercentage { get; private set; }

        public Basketball(decimal score, decimal fieldGoalAttempts, decimal fieldGoalPercentage, decimal freeThrowMade, decimal freeThrowAttempts, decimal freeThrowPercentage, decimal rebounds, decimal turnOvers, decimal fouls, decimal teamFouls, decimal steals, decimal assists, decimal threePointersMade, decimal threePointersAttempted, decimal threePointersPercentage):base(score, fieldGoalAttempts, fieldGoalPercentage)
        {
            if (freeThrowMade < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (freeThrowAttempts < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (freeThrowPercentage < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (rebounds < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (turnOvers < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (fouls < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (teamFouls < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (steals < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (assists < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (threePointersMade < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (threePointersAttempted < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (threePointersPercentage < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            FreeThrowMade = freeThrowMade;
            FreeThrowAttempts = freeThrowAttempts;
            FreeThrowPercentage = freeThrowPercentage;
            Rebounds = rebounds;
            TurnOvers = turnOvers;
            Fouls = fouls;
            TeamFouls = teamFouls;
            Steals = steals;
            Assists = assists;
            ThreePointersMade = threePointersMade;
            ThreePointeresAttempted = threePointersAttempted;
            ThreePointersPercentage = threePointersPercentage;
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
