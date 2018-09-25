using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public class AverageResult : ResultStrategy
    {
        private int diceSize;
        private int diceNumber;
        private AdvantageOptions advantageOption;
        private int rerollLimit;

        public AverageResult(int diceSize, int diceNumber, AdvantageOptions advantageOption, int rerollLimit)
        {
            this.diceSize = diceSize;
            this.diceNumber = diceNumber;
            this.advantageOption = advantageOption;
            this.rerollLimit = rerollLimit;
        }


        public double Result()
        {
            if (diceNumber <= 0)
            {
                return 0;
            }
            AverageStrategy averageStrategy;


            if (advantageOption == AdvantageOptions.Regular)
            {
                averageStrategy = new RegularAverage(rerollLimit, diceSize);
            }
            else if (advantageOption == AdvantageOptions.Advantage)
            {
                averageStrategy = new AdvantageAverage(rerollLimit, diceSize);
            }
            else
            {
                averageStrategy = new DissadvantageAverage(rerollLimit, diceSize);
            }
            if(diceNumber<=0)
            {
                return 0;
            }

            return averageStrategy.GetAverage() * diceNumber ;
        }
    }
}
