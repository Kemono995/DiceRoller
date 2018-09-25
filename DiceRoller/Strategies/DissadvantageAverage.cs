using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public class DissadvantageAverage : AverageStrategy
    {
        private int rerollLimit;
        private int diceSize;

        public DissadvantageAverage(int rerollLimit, int diceSize)
        {
            this.rerollLimit = rerollLimit;
            this.diceSize = diceSize;
        }


        public double GetAverage()
        {
            double retVal = 0.0;
            if (diceSize <= 0)
            {
                return retVal;
            }

            for (int i = 1; i <= diceSize; i++)
            {
                for (int j = 1; j <= diceSize; j++)
                {
                    double firstDice = i;

                    if (i <= rerollLimit)
                    {
                        firstDice = DiceAverage.Average(diceSize);
                    }
                    double secondDice = j;
                    if (j <= rerollLimit)
                    {
                        secondDice = DiceAverage.Average(diceSize);
                    }

                    if (firstDice < secondDice)
                    {
                        retVal += firstDice;
                    }
                    else
                    {
                        retVal += secondDice;
                    }
                }
            }
            return retVal / (diceSize * diceSize);

        }
    }
}
