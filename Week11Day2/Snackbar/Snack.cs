using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snackbar
{
    public class Snack
    {
        private string name;
        private double price;
        private int amount;

        public Snack(string name, double price, int amount)
        {
             this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public bool DecreaseStock(int amount)
        {
            if(amount <= this.amount)
            {
                this.amount -= amount;
                return true;
            }
            return false;
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetAmountInStock()
        {
            return this.amount;
        }

        public bool ChangePrice(double newPrice)
        {
            if(newPrice > 0)
            {
                this.price = newPrice;
                return true;
            }
            return false;
        }
        public string ChangeAmount(int amount)
        {
            if(amount < 0)
            {
                this.amount = amount;
                return $"{this.name} amount successfully changet to: {amount}";
            }
            else
            {
                return $"Amount has to be bigger than 0";
            }
        }
    }
}
