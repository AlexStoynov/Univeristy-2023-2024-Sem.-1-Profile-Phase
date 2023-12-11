using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesApp
{
    public class Expense
    {
        private string name;
        private double amount;

        public void initializeExpense(string name, double amount)
        {
            this.name = name;
            this.amount = amount;  
        }

        public string getInfo()
        {
            return $"{this.name} - {this.amount:f2}";
        }

        public double getAmount()
        {
            return this.amount;
        }
    }
}
