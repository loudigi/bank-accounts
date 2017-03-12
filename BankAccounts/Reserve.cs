using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BankAccounts
{
    class Reserve : Account
    {
        static List<string> myReserveLog = new List<string>();

        static string AccountType = "Reserve";
        static int AccountNumber = 231453675;
        static double AccountBalance = 300;

        public Reserve()
        {

        }

        static double DepositAmount { get; set; }
        static double WithdrawAmount { get; set; }

        static public void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            try
            {
                DepositAmount = double.Parse(Console.ReadLine());
            }
            catch (FormatException rdm)
            {
                Console.WriteLine("You must enter a dollar amount");
                throw;
            }
            AccountBalance += DepositAmount;
            Console.WriteLine("{0} have been deposited into your {1} Account.\nYour new balance is {2}", ToCurrency(DepositAmount), AccountType, ToCurrency(AccountBalance));

            myReserveLog.Add((DateTime.Today.ToString("d")) + " " + "+" + ToCurrency(DepositAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();

        }

        static public void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw.");
            try
            {
                WithdrawAmount = double.Parse(Console.ReadLine());
            }
            catch (FormatException rwm)
            {
                Console.WriteLine("You must enter a dollar amount");
                throw;
            }
            AccountBalance -= WithdrawAmount;

            if (WithdrawAmount > AccountBalance)
            {
                Console.WriteLine("\nALERT: The withdraw amount is more than your current balance.\nYou have 24 hours to deposit funds before \noverdraft fees are posted to your account.\n");
            }

            Console.WriteLine("{0} has been withdrawn from your {1} Account.\nYour new balance is {2}", ToCurrency(WithdrawAmount), AccountType, ToCurrency(AccountBalance));

            myReserveLog.Add((DateTime.Today.ToString("d")) + " " + "-" + ToCurrency(WithdrawAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();

        }

        static public void ShowBalance()
        {
            Console.Write(String.Format(" {0,-16}", AccountType + " Account"));
            Console.WriteLine(" # {0} Balance:{1}", AccountNumber, ToCurrency(AccountBalance));
        }

            static public void SendLog()
        {
            StreamWriter rWriter = new StreamWriter(@"..\..\ReserveStatement.txt");

            using (rWriter)
            {
                rWriter.WriteLine(ClientName + " " + AccountType + " " + AccountNumber);
                foreach (string line in myReserveLog)
                    rWriter.WriteLine(line);
            }
        }
    }
}
