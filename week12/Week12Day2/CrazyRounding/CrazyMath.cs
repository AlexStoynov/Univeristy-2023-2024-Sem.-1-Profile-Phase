using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRounding
{
    public class CrazyMath
    {
        private double num;
        private Random rand;
        public CrazyMath(double num)
        {
            this.num = num;
            rand = new Random();
        }

        public List<double> RoundToWhole()
        {
            int chance = rand.Next(1, 3);
            List<double> nums = new List<double>();

            for(int i = 0; i < 10; i++)
            {
                if (chance == 1)
                {
                    nums.Add(Math.Ceiling(num));
                }
                else
                {
                    nums.Add(Math.Floor(num));
                }
                chance = rand.Next(1, 3);
            }

            return nums;
        }

        public List<double> RoundToTenth()
        {
            int chance = rand.Next(1, 3);
            List<double> nums = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                if (chance == 1)
                {
                    nums.Add(Math.Ceiling(num * 10) / 10);
                }
                else
                {
                    nums.Add(Math.Floor(num * 10) / 10);
                }
                chance = rand.Next(1, 3);
            }

            return nums;
        }

        public List <double> RoundToHundreth()
        {
            int chance = rand.Next(1, 3);
            List<double> nums = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                if (chance == 1)
                {
                    nums.Add(Math.Ceiling(num * 100) / 100);
                }
                else
                {
                    nums.Add(Math.Floor(num * 100) / 100);
                }
                chance = rand.Next(1, 3);
            }

            return nums;
        }

        public double GetNum()
        {
            return this.num;
        }
    }
}
