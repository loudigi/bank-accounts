using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankAccounts
{
    class Account
    {
        //private string accountType;
        //private int accountNumber;
        private string clientName = "Mike Jones";
        //private double accountBalance;
        public Account()
        {

        }
        public Account(string _accountType, int _accountNumber, double _accountBalance)
        {
            AccountType = _accountType;
            AccountNumber = _accountNumber;
            AccountBalance = _accountBalance;
        }

        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public double AccountBalance { get; set; }
        public string ClientName
        {
            get { return this.clientName; }
        }
        
            

        public virtual void ShowBalance()
        {
            Console.WriteLine("Your "+ AccountType + "Account " + "balance is " + ToCurrency(AccountBalance));
            ShowMenu();
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
            Console.WriteLine("\nPlease select from the following "+ AccountType + " Account " + "options\n" + 
                "1. Show Balance\n" + 
                "2. Make a Deposit\n" + 
                "3. Make a Withdraw\n" + 
                "4. Return to Main Menu\n" + 
                "5. Exit");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    ShowBalance();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    Withdraw();
                    break;
                case 4:
                    
                    break;
                case 5:
                    Console.WriteLine("Thank you for using Fat Stacks Banking");
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That was not an available option");
                    ShowMenu();
                    break;
            }


        }
        
        public string ToCurrency(double nums)
        {
            string cash = nums.ToString("C", CultureInfo.CurrentCulture);
            return cash;
        }
        

    }
}
