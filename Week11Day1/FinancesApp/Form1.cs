namespace FinancesApp
{
    public partial class Form1 : Form
    {
        FinancialManager financialManager = new FinancialManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddExpense_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            double expAmount = double.Parse(ExpenseAmount.Value.ToString());
            financialManager.AddExpense(expense, ExpenseName.Text.ToString(), expAmount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Expense> transactionLog =  financialManager.GetExpenses();

            foreach (Expense expense in transactionLog)
            {
                listBox1.Items.Add(expense.getInfo());
            }
        }

        private void showExpWithSameAmountBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Expense> transactionLog = financialManager.GetExpenses();

            foreach (Expense expense in transactionLog)
            {
                if(expense.getAmount() == double.Parse(amount2.Value.ToString()))
                {
                    listBox1.Items.Add(expense.getInfo());
                }
            }
        }
    }
}