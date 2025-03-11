using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class User
    {
        private string name { get; set; }
        private decimal balance { get; set; }
        private string balance_Currency { get; set; }

        public User(string name, decimal balance, string balance_Currency)
        {
            this.name = name;
            this.balance = balance;
            this.balance_Currency = balance_Currency;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string Balance_Currency
        {
            get { return balance_Currency; }
            set { balance_Currency = value; }
        }

        public virtual void GetUserInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Balance: {0} {1}", balance, balance_Currency);
        }
    }
}
