﻿using System;
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
        static double AccountBalance = 200;

        public Savings()
        {

            

        }

        static double DepositAmount { get; set; }
        static double WithdrawAmount { get; set; }

        static public void Deposit()
        {
            Console.WriteLine("Please enter the amount you wish to deposit.");
            DepositAmount = double.Parse(Console.ReadLine());
            AccountBalance += DepositAmount;
            Console.WriteLine("{0} have been deposited into your {1} Account.\nYour new balance is {2}", ToCurrency(DepositAmount), AccountType, ToCurrency(AccountBalance));

            mySavingsLog.Add((DateTime.Today.ToString("d")) + " " + "+" + ToCurrency(DepositAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();


        }

        static public void Withdraw()
        {
            Console.WriteLine("Please enter the amount you wish to withdraw.");
            WithdrawAmount = double.Parse(Console.ReadLine());
            AccountBalance -= WithdrawAmount;

            if (WithdrawAmount > AccountBalance)
            {
                Console.WriteLine("\nALERT: The withdraw amount is more than your current balance.\nYou have 24 hours to deposit funds before \noverdraft fees are posted to your account.\n");
            }

            Console.WriteLine("{0} has been withdrawn from your {1} Account.\nYour new balance is {2}", ToCurrency(WithdrawAmount), AccountType, ToCurrency(AccountBalance));

            mySavingsLog.Add((DateTime.Today.ToString("d")) + " " + "-" + ToCurrency(WithdrawAmount) + " Running Balance: " + ToCurrency(AccountBalance));

            SendLog();

            
        }

        static public void ShowBalance()
        {
            Console.Write(String.Format(" {0,-16}", AccountType + " Account"));
            Console.WriteLine(" # {0} Balance:{1}", AccountNumber, ToCurrency(AccountBalance));
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
