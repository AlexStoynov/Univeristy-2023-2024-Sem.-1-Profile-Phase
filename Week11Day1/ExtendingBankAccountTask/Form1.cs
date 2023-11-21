namespace ExtendingBankAccountTask
{
    public partial class Form1 : Form
    {
        BankAccount checkingAccount = new BankAccount();
        BankAccount savingsAccount = new BankAccount();
        public Form1()
        {
            InitializeComponent();
            checkingAccount.InitializeBankAccount("Checking", 0);
            savingsAccount.InitializeBankAccount("Savings", 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (rbChecking.Checked)
            {
                checkingAccount.DepositMoney(decimal.Parse(amountMoney.Text));
                checkingAccBalance.Text = checkingAccount.GetBalance().ToString();
            }
            else if (rbSavings.Checked)
            {
                savingsAccount.DepositMoney(decimal.Parse(amountMoney.Text));
                savingsAccBalance.Text = savingsAccount.GetBalance().ToString();
            }
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (rbChecking.Checked)
            {
                if(!checkingAccount.WithdrawMoney(decimal.Parse(amountMoney.Text)))
                {
                    insufficientFundsLbl.Text = "Insufficient funds!";
                }
                else
                {
                    checkingAccount.WithdrawMoney(decimal.Parse(amountMoney.Text));
                    checkingAccBalance.Text = checkingAccount.GetBalance().ToString();
                }
            }
            else if (rbSavings.Checked)
            {
                if(!savingsAccount.WithdrawMoney(decimal.Parse(amountMoney.Text)))
                { 
                    insufficientFundsLbl.Text = "Insufficient funds!";
                }
                else
                {
                    savingsAccount.WithdrawMoney(decimal.Parse(amountMoney.Text));
                    savingsAccBalance.Text = savingsAccount.GetBalance().ToString();
                }
            }
        }

        private void rbChecking_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}