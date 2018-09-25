using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public class TotalResult : ResultStrategy
    {
        private int diceSize;
        private int diceNumber;
        private AdvantageOptions advantageOption;
        private int rerollLimit;

        public TotalResult(int diceSize, int diceNumber, AdvantageOptions advantageOption, int rerollLimit)
        {
            this.diceSize = diceSize;
            this.diceNumber = diceNumber;
            this.advantageOption = advantageOption;
            this.rerollLimit = rerollLimit;
        }

        public double Result()
        {
            RollStrategy rollStrategy;
            

            if (advantageOption == AdvantageOptions.Regular)
            {
                rollStrategy = new RegularRoll(rerollLimit);
            }
            else if (advantageOption == AdvantageOptions.Advantage)
            {
                rollStrategy = new AdvantageRoll(rerollLimit);
            }
            else
            {
                rollStrategy = new DissadvantageRoll(rerollLimit);
            }
            List<int> rolls = rollStrategy.rollDice(diceNumber, diceSize);

            if (rolls.Count==0)
            {
                return 0;
            }
            double retVal = 0;

            foreach (var item in rolls)
            {
                retVal += item;
            }
            return retVal;
        }
    }
}
