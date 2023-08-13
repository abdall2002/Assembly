using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class BankAccount
    {
        public string accountNo;
        public string holder;
        public decimal balance;

        private string AccountNo => accountNo;
        private string Holder => holder;
        private decimal Balance => balance;

        public event EventHandler OnNegativeBalance;

        public BankAccount()
        {
                
        }

        public BankAccount(string accountNo, string holder, decimal balance)
        {
            this.accountNo = accountNo;
            this.holder = holder;
            this.balance = balance;
        }

        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void Withdraw(decimal amount) 
        {
            this.balance -= amount;
            if(balance < 0) 
            {
                this.OnNegativeBalance.Invoke(this, null);
            }
        }

        public override string ToString()
        {
            return $"{{ Account No.: {accountNo}, Holder: {holder}, Balance: ${balance}}}";
        }

    }
}
