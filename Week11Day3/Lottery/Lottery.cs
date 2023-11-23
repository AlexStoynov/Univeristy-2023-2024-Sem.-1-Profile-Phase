using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class Lottery
    {
        private int maxValue;
        private int numOfWantedNums;

        public Lottery(int maxValue, int numOfWantedNums)
        {
            this.maxValue = maxValue;
            this.numOfWantedNums = numOfWantedNums;
        }

        public List<int> GenerateNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < this.numOfWantedNums; i++)
            {
                Random rand = new Random();
                numbers.Add(rand.Next(1, maxValue));
            }

            return numbers;
        }

        public int DrawOneByOne()
        {
            Random rand = new Random();
            int numDrawn = rand.Next(1, maxValue);
            return numDrawn;
        }
    }
}
