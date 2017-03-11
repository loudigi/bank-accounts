using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccounts
{
    class Savings : Account
    {
        static List<string> mySavingsLog = new List<string>();

        static string AccountType = "Savings";
        static int AccountNumber = 989765261;
        static double AccountBalance = 100;

        public Savings()
        {

            

        }

        static double DepositAmount { get; set; }
        static double WithDrawAmount { get; set; }

        static public void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            DepositAmount = double.Parse(Console.ReadLine());
            AccountBalance += DepositAmount;
            Console.WriteLine("{0} have been deposited into your {1} Account. Your new balance is {2}", ToCurrency(DepositAmount), AccountType, ToCurrency(AccountBalance));

            mySavingsLog.Add((DateTime.Today.ToString("d")) + " " + "+" + ToCurrency(DepositAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();


        }

        static public void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw.");
            WithDrawAmount = double.Parse(Console.ReadLine());
            AccountBalance -= WithDrawAmount;
            Console.WriteLine("{0} has been withdrawn from your {1} Account. Your new balance is {2}", ToCurrency(WithDrawAmount), AccountType, ToCurrency(AccountBalance));

            mySavingsLog.Add((DateTime.Today.ToString("d")) + " " + "-" + ToCurrency(WithDrawAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();

            // ShowMenu();
        }

        static public void SendLog()
        {
            StreamWriter sWriter = new StreamWriter(@"..\..\SavingsStatement.txt");

            using (sWriter)
            {
                sWriter.WriteLine(ClientName + " " + AccountType + " " + AccountNumber);
                foreach (string line in mySavingsLog)
                    sWriter.WriteLine(line);
            }
        }
    }
}
