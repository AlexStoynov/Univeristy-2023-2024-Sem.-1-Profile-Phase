using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Car
    {
        private string brand;
        private int currSpeed;
        private int maxSpeed;

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetInfo()
        {
            return $"Speed of my {this.brand} is {this.currSpeed} km/h and its maximum speed is {this.maxSpeed} km/h";
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public void SpeedUp()
        {
            if(this.currSpeed + 7 <= this.maxSpeed)
            {
                this.currSpeed += 7;
            }
            else
            {
                this.currSpeed = maxSpeed;
            }
        }

        public void SlowDown()
        {
            if(this.currSpeed - 10 >= 0)
            {
                this.currSpeed -= 10;
            }
            else
            {
                this.currSpeed = 0;
            }
        }
    }
}
