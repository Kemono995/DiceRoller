using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Strategies
{
    public interface RollStrategy
    {
        List<int> rollDice(int diceNumber, int diceSize);
    }
}
