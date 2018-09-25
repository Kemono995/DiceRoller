using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public class DiceAverage
    {

        public static double Average(int diceSize)
        {
            double retVal = 0.0;

            if(diceSize<=0)
            {
                return retVal;
            }

            retVal = (diceSize + 1.0) / 2.0;



            return retVal;
        }

        
    }
}
