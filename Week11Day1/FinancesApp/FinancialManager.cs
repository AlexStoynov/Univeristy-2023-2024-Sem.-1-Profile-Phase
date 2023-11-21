using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancesApp
{
    public class FinancialManager
    {
        private List<Expense> expenses;

        public FinancialManager()
        {
            expenses = new List<Expense>();
        }

        public void AddExpense(Expense expense, string expenseName, double expenseAmount)
        {
            expense = new Expense();
            expense.initializeExpense(expenseName, expenseAmount);
            this.expenses.Add(expense);
        }

        public List<Expense> GetExpenses()
        {
            return this.expenses;
        }
    }
}
