using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Reserve : Account
    {
        public Reserve()
        {
            AccountType = "Reserve";
            AccountNumber = 998564254;
            AccountBalance = 100;
        }

        private double DepositAmount { get; set; }
        private double WithDrawAmount { get; set; }

        public override void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            DepositAmount = double.Parse(Console.ReadLine());
            AccountBalance += DepositAmount;
            Console.WriteLine("{0} have been deposited into your {1}. Your new balance is {2}", ToCurrency(DepositAmount), AccountType, ToCurrency(AccountBalance));

            ShowMenu();
        }

        public override void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw.");
            WithDrawAmount = double.Parse(Console.ReadLine());
            AccountBalance -= WithDrawAmount;
            Console.WriteLine("{0} has been withdrawn from your {1} Account. Your new balance is {2}", ToCurrency(WithDrawAmount), AccountType, ToCurrency(AccountBalance));

            ShowMenu();

        }
    }
}
