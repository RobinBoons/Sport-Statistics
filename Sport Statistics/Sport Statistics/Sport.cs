using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public abstract class Sport
    {
        public decimal Score { get; set; }
        public decimal Attempts { get; set; }
        public decimal ScorePercentage { get; private set; }

        public Sport(decimal score, decimal attempts, decimal scorePercentage)
        {
            if (score < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (attempts < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (scorePercentage < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Score = score;
            Attempts = attempts;
            ScorePercentage = scorePercentage;
        }

        public decimal CalculatePercentage(decimal score, decimal attempts)
        {
            if(score <= 0 || attempts < score || attempts <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            ScorePercentage = score / attempts;
            return ScorePercentage * 100;
        }

        public override string ToString()
        {
            return Score + ", " + Attempts + ", " + ScorePercentage;
        }

        public abstract void addStatics(int propName);
        
    }
}
