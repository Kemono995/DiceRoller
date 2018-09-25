using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class RandomManager
    {

        private static Random random;

        public static int Next(int limit)
        {
            if(random==null)
            {
                random = new Random(new DateTime().Millisecond);
                random.Next(50);
                random.Next(52);
                random.Next(12);
                random.Next(6);
            }
            return random.Next(limit)+1;
        }

    }
}
