namespace ExtendingBankAccountTask
{
    public partial class Form1 : Form
    {
        private BankAccount checkingAccount;
        private BankAccount savingsAccount;

        public Form1()
        {
            InitializeComponent();
            checkingAccount = new BankAccount();
            savingsAccount = new BankAccount();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (rbChecking.Checked)
            {
                checkingAccount.DepositMoney(double.Parse(amountMoney.Text));
                checkingAccBalance.Text = checkingAccount.GetBalance().ToString();
            }
            else if (rbSavings.Checked)
            {
                savingsAccount.DepositMoney(double.Parse(amountMoney.Text));
                savingsAccBalance.Text = savingsAccount.GetBalance().ToString();
            }
            listBox1.Items.Add($"You deposited {amountMoney.Text}$ to your account.");
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(amountMoney.Text);
            if (rbChecking.Checked)
            {
                checkingAccount.WithdrawMoney(amount);
                checkingAccBalance.Text = checkingAccount.GetBalance().ToString();
            }
            else if (rbSavings.Checked)
            {
                savingsAccount.WithdrawMoney(amount);
                savingsAccBalance.Text = savingsAccount.GetBalance().ToString();
            }
            listBox1.Items.Add($"You withdrew {amount}$ from your account.");
        }

        private void rbChecking_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accountIDLbl.Text = checkingAccount.AccountNumber.ToString();
        }
    }
}