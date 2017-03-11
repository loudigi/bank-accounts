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
        static double WithDrawAmount { get; set; }

        static public void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            DepositAmount = double.Parse(Console.ReadLine());
            AccountBalance += DepositAmount;
            Console.WriteLine("{0} have been deposited into your {1} Account.\nYour new balance is {2}", ToCurrency(DepositAmount), AccountType, ToCurrency(AccountBalance));

            myReserveLog.Add((DateTime.Today.ToString("d")) + " " + "+" + ToCurrency(DepositAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();


        }

        static public void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw.");
            WithDrawAmount = double.Parse(Console.ReadLine());
            AccountBalance -= WithDrawAmount;
            Console.WriteLine("{0} has been withdrawn from your {1} Account.\nYour new balance is {2}", ToCurrency(WithDrawAmount), AccountType, ToCurrency(AccountBalance));

            myReserveLog.Add((DateTime.Today.ToString("d")) + " " + "-" + ToCurrency(WithDrawAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();

            // ShowMenu();
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
