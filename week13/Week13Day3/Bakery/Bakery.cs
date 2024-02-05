using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bakery
{
    public class Bakery
    {
        private string bakeryName;
        private int VAT_PERCENTAGE = 9;
        private double revenue = 0;
        private List<Sandwich> sandwiches;
        private List<Ingredient> ingredients;
        private List<Sandwich> sandwichesSold;


        public Bakery(string name)
        {
            this.bakeryName = name;
            sandwiches = new List<Sandwich>();
            ingredients = new List<Ingredient>();
            sandwichesSold = new List<Sandwich>();

            Ingredient cucumber = new Ingredient("Cucumber", 0.05);
            ingredients.Add(cucumber);
            Ingredient tomato = new Ingredient("Tomato", 0.15);
            ingredients.Add(tomato);
            Ingredient cheddar = new Ingredient("Cheddar", 0.2);
            ingredients.Add(cheddar);
            Ingredient ham = new Ingredient("Ham", 0.15);
            ingredients.Add(ham);
            Ingredient chorizo = new Ingredient("Chorizo", 0.25);
            ingredients.Add(chorizo);
            Ingredient Apple = new Ingredient("Apple", 0.1);
            ingredients.Add(Apple);
            Ingredient Tuna = new Ingredient("Tuna", 0.2);
            ingredients.Add(Tuna);
            Ingredient Salmon = new Ingredient("Smoked Salmon", 0.4);
            ingredients.Add(Salmon);
            Ingredient CreamCheese = new Ingredient("Cream cheese", 0.15);
            ingredients.Add(CreamCheese);
            Ingredient GoudaCheese = new Ingredient("Gouda cheese", 0.1);
            ingredients.Add(GoudaCheese);
        }


        public string Name { get { return bakeryName; } }
        public List<Ingredient> Ingredients { get { return ingredients; } set { ingredients = value; } }
        public List<Sandwich> SandwichList { get { return sandwiches; } set { sandwiches = value; } }
        public List<Sandwich> Sold { get { return sandwichesSold; } set { sandwichesSold = value; } }
        public double Revenue { get { return revenue; } set { revenue = value; } }

        public void AddSandwich(string name, double basePrice, BreadType bread)
        {
            Sandwich sandwich = new Sandwich(name, basePrice, bread);
            sandwiches.Add(sandwich);
        }

        public List<Sandwich> GetAvailableSandwiches()
        {
            return this.sandwiches;
        }

        public List<Sandwich> GetAvailableSandwiches(BreadType bread)
        {
            List<Sandwich> sandwichesWithSelectedBreadType = new List<Sandwich>();

            foreach (Sandwich sandwich in sandwiches)
            {
                if (sandwich.Bread == bread)
                {
                    sandwichesWithSelectedBreadType.Add(sandwich);
                }
            }
            return sandwichesWithSelectedBreadType;
        }

        public double SellSandwich(Sandwich sandwich)
        {
            sandwichesSold.Add(sandwich);
            double price = sandwich.GetPrice();
            revenue += price;

            return price / 100 * (100 + VAT_PERCENTAGE);
        }

        public double CalculateRevenue(bool withVat)
        {
            if (withVat)
            {
                return revenue / 100 * (100 + VAT_PERCENTAGE);
            }

            return revenue;
        }
    }
}
