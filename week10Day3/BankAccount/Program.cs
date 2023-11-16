namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.InitializeBankAccount("Joro Mishev", 01234);
            account.DepositMoney(23425);
            Console.WriteLine(account.GetInfo());
            account.WithdrawMoney(320);
            Console.WriteLine(account.GetInfo());
            account.WithdrawMoney(2523637);
            Console.WriteLine(account.GetInfo());
            account.WithdrawMoney(23105);
            Console.WriteLine(account.GetInfo());
        }
    }
}