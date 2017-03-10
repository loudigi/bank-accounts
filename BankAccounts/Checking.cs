using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccounts
{
    class Checking : Account
    {
        public Checking()
        {
            AccountType = "Checking";
            AccountNumber = 334556567;
            AccountBalance = 100;
            StartLogger();
        }

        private double DepositAmount { get; set; }
        private double WithDrawAmount { get; set; }

        public override void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            DepositAmount = double.Parse(Console.ReadLine());
            AccountBalance += DepositAmount;
            Console.WriteLine("{0} have been deposited into your {1} Account. Your new balance is {2}", ToCurrency(DepositAmount), AccountType, ToCurrency(AccountBalance));

            StreamWriter cdWriter = new StreamWriter(@"..\..\CheckingStatement.txt");
            cdWriter.WriteLine((DateTime.Today.ToString("d")) + " " + "+" + ToCurrency(DepositAmount) + " Running Balance: " + ToCurrency(AccountBalance));
            cdWriter.Close();
            ShowMenu();
        }

        public override void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw.");
            WithDrawAmount = double.Parse(Console.ReadLine());
            AccountBalance -= WithDrawAmount;
            Console.WriteLine("{0} has been withdrawn from your {1} Account. Your new balance is {2}", ToCurrency(WithDrawAmount), AccountType, ToCurrency(AccountBalance));
            
            StreamWriter cwWriter = new StreamWriter(@"..\..\CheckingStatement.txt",true);
          
            cwWriter.WriteLine((DateTime.Today.ToString("d")) + " " + "-" + ToCurrency(WithDrawAmount) + " Running Balance: " + ToCurrency(AccountBalance));
            cwWriter.Close();

            ShowMenu();
        }

        //Initialize statement logger file with client details.
        public void StartLogger()
        {
            StreamWriter startWriter = new StreamWriter(@"..\..\CheckingStatement.txt");
            startWriter.WriteLine(ClientName + " " + AccountType + " " + AccountNumber);
           
            startWriter.Close();
        }
    }
}
