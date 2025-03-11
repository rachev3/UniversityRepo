using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class SpecialUser : User
    {
        public SpecialUser(string name, decimal balance, string balance_Currency) : base(name, balance, balance_Currency)
        {

        }
        public override void GetUserInfo()
        {
            Console.WriteLine("Hello, Special User!");
            base.GetUserInfo();
        }
    }
}
