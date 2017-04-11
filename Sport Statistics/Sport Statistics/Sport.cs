﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Statistics
{
    public abstract class Sport
    {
        public decimal Score { get; private set; }
        public decimal Attempts { get; private set; }
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

        public void CalculatePercentage()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
