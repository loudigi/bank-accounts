using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Account
    {
        //private string accountType;
        //private int accountNumber;
        //private string clientName;
        //private double accountBalance;

        public Account()
        {

        }

        public int AccountType { get; set; }
        public int AccountNumber { get; set; }
        public string ClientName { get; set; }
        public double AccountBalance { get; set; }

        public virtual void ShowBalance()
        {
            Console.WriteLine(AccountType + "Show balance");
        }

        public virtual void Deposit()
        {
            Console.WriteLine(AccountType + "Make a deposit");
        }

        public virtual void Withdraw()
        {
            Console.WriteLine(AccountType + "Taking money out?");
        }

        public virtual void ShowMenu()
        {
            Console.WriteLine("Show Menu");
        }
        

    }
}
