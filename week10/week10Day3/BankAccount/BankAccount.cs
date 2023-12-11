using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private string client;
        private int accountNum;
        private decimal balance;

        public void InitializeBankAccount(string newClient, int newAccountNumber)
        {
            if(newClient != "")
            {
                this.client = newClient;
            }
            else
            {
                Console.WriteLine("Name is not valid!");
            }
            this.accountNum = newAccountNumber;
            this.balance = 0;
        }

        public void DepositMoney(decimal amount)
        {
            this.balance += amount;
        }

        public bool WithdrawMoney(decimal amount)
        {
            if(this.balance < amount)
            {
                Console.WriteLine("Insufficient funds!");
                return false;
            }
            else
            {
                this.balance -= amount;
                return true;
            }
        }

        public string GetInfo()
        {
            return $"Client {this.client} ({this.accountNum}): {this.balance} euro(s)";
        }
    }
}
