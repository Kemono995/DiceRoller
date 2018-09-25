using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public class RegularRoll : RollStrategy
    {
        private int rerollThreshold;

        public RegularRoll(int rerollThreshold)
        {
            this.rerollThreshold = rerollThreshold;
        }


        public List<int> rollDice(int diceNumber, int diceSize)
        {
           

            List<int> retVal = new List<int>();

            if(rerollThreshold >= diceSize || diceSize ==0)
            {
                return retVal;
            }

            for (int i = 0; i < diceNumber; i++)
            {
                int firstValue = RandomManager.Next(diceSize);
                if (firstValue > rerollThreshold)
                {
                    retVal.Add(firstValue);
                }
                else
                {
                    retVal.Add(RandomManager.Next(diceSize));
                }
            }


            return retVal;
        }
    }
}
