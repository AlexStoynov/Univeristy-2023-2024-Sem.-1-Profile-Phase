using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class Ingredient
    {
        string name;
        double price;

        public string Name { get { return name; } set { this.name = value; } }
        public double Price { get { return price; } set { this.price = value; } }
        public Ingredient(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
