using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public class AdvantageRoll : RollStrategy
    {
        private int rerollThreshold;

        public AdvantageRoll(int rerollThreshold)
        {
            this.rerollThreshold = rerollThreshold;
        }


        public List<int> rollDice(int diceNumber, int diceSize)
        {
 

            List<int> retVal = new List<int>();

            if (diceSize == 0)
            {
                return retVal;
            }

            for (int i = 0; i < diceNumber; i++)
            {
                int firstval = RandomManager.Next(diceSize); 
                if (firstval <= rerollThreshold)
                {
                    firstval = RandomManager.Next(diceSize); 
                }
                int secondVal = RandomManager.Next(diceSize); 
                if (secondVal <= rerollThreshold)
                {
                    secondVal = RandomManager.Next(diceSize);
                }

                if (firstval < secondVal)
                {
                    retVal.Add(secondVal);
                }else
                {
                    retVal.Add(firstval);
                }
            }

            return retVal;
        }
    }
}
