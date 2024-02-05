using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class Sandwich
    {
        private string name;
        private double basePrice;
        private BreadType bread;
        private List<Ingredient> ingredients;

        public string Name { get { return name; } }
        public double BasePrice { get { return basePrice; } }
        public BreadType Bread { get { return bread; } }
        public List<Ingredient> Ingredients { get { return ingredients; } set { this.ingredients = value; } }

        public Sandwich(string name, double basePrice, BreadType bread)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.bread = bread;
            ingredients = new List<Ingredient>();
        }
        public void AddIngredient(Ingredient ingredient)
        {
            if (ingredients.Count < 6)
            {
                ingredients.Add(ingredient);
            }
        }
        public string GetInfo()
        {
            string ingredients1 = string.Empty;
            foreach (Ingredient ing in ingredients)
            {
                ingredients1 += $"{ing.Name}, ";
            }

            return $"{this.Name} ({bread}, {ingredients1})";
        }
        public double GetPrice()
        {
            double price = basePrice;
            foreach (Ingredient ingredient in ingredients)
            {
                price += ingredient.Price;
            }
            return price;
        }
    }
}
