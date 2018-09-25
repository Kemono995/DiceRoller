using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public class RegularAverage : AverageStrategy
    {
        private int rerollLimit;
        private int diceSize;

        public RegularAverage(int rerollLimit, int diceSize)
        {
            this.rerollLimit = rerollLimit;
            this.diceSize = diceSize;
        }


        public double GetAverage()
        {
            double retVal = 0.0;
            if(diceSize<=0)
            {
                return retVal;
            }

            for (int i = 1; i <= diceSize; i++)
            {
                if(i<=rerollLimit)
                {
                    retVal += DiceAverage.Average(diceSize);
                }else
                {
                    retVal += i;
                }
            }
            return retVal / diceSize;

        }
    }
}
