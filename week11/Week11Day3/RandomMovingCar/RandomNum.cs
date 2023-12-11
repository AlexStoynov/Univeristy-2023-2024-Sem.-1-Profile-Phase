using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMovingCar
{
    public class RandomNum
    {
        Random rand = new Random();
        int randNumber;

        public RandomNum()
        {
            randNumber = rand.Next(1, 3);
        }
        public int GetNumber()
        {
            return randNumber;
        }
    }
}
