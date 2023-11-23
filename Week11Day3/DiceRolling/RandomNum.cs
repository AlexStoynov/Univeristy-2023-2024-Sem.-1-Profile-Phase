using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling
{
    public class RandomNum
    {
        private Random random = new Random();
        private int num;

        public RandomNum()
        {
            num = random.Next(1, 7);
        }
        public int GetNumber()
        {
            return num;
        }
    }
}
