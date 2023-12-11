namespace ExtendingBankAccountTask
{
    public class BankAccount
    {
        private int accountNum;
        private double balance;
        private List<double> transactions;
        private int nextNum = 1001;

        public int AccountNumber
        {
            get { return this.accountNum; }
        }

        public double Balance
        {
            get { return this.balance; }
            private set
            {
                if (value < 0)
                {
                    this.balance = 0;
                }
                else
                {
                    this.balance = value;
                }
            }
        }


        public BankAccount()
        {
            accountNum = nextNum;
            this.Balance = balance;
            transactions = new List<double>();
            nextNum++;
        }

        public BankAccount(int bankAccId)
        {
            this.accountNum = bankAccId;
            this.Balance = balance;
            transactions = new List<double>();
        }

        public void DepositMoney(double amount)
        {
            this.balance += amount;
            transactions.Add(amount);
        }

        public bool WithdrawMoney(double amount)
        {
            if (this.Balance < amount)
            {
                throw new ArgumentException("Insufficient funds!");
            }
            else
            {
                this.Balance -= amount;
                transactions.Add(amount);
                return true;
            }
        }

        public List<double> GetTransactions()
        {
            return transactions;
        }

        public double GetBalance()
        {
            return this.Balance;
        }

        public string GetInfo()
        {
            return $"Client id ({this.AccountNumber}): {this.Balance} euro(s)";
        }
    }
}