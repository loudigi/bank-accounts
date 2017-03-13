using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccounts
{
    class Program
    {


        static void Main(string[] args)
        {

           
            Console.WriteLine("\nWelcome to {0}!", Account.BankName);

            //Start loop for Main Menu 
            int userInput = 0;
            do
            {
                try
                {
                    userInput = MainMenu();
                }
                catch (FormatException mm)
                {
                    Console.WriteLine("Please enter a numeric value");
                }
                switch (userInput)
                {
                    case 1:
                        ClientInfo();
                        break;
                    case 2:
                        Console.WriteLine("---------------------------------------------");
                        Checking.ShowBalance();
                        Savings.ShowBalance();
                        Reserve.ShowBalance();
                        Console.WriteLine("---------------------------------------------");
            
                        break;
                    case 3:
                        MainDeposit();
                        break;
                    case 4:
                        MainWithdraw();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using {0}.", Account.BankName);
                        break;
                    default:
                        Console.WriteLine(" This not an available option. Returning to Main Menu");
                        break;
                }


            } while (userInput != 5);

            System.Environment.Exit(0);


        }

        static int MainMenu()
        {

            Console.WriteLine("\n\n[ MAIN MENU ]\n\n Please select from the following options\n" +
                "  1.   View Profile\n" +
                "  2.   Account Balance\n" +
                "  3. + Deposit Funds\n" +
                "  4. + Withdraw Funds\n" +
                "  5.   Exit");

            int selection = int.Parse(Console.ReadLine());
            return selection;

        }

        static void MainDeposit()
        {
            Console.WriteLine("  ->[ DEPOSIT MENU ]\n\n    Select an account to deposit to\n" +
                "    1. Checking\n" +
                "    2. Savings\n" +
                "    3. Reserve\n" +
                "    4. Return to Main Menu");
            try
            {
                int depositSelection = int.Parse(Console.ReadLine());
                if (depositSelection == 1)
                {
                    Checking.Deposit();
                }
                else if (depositSelection == 2)
                {
                    Savings.Deposit();
                }
                else if (depositSelection == 3)
                {
                    Reserve.Deposit();
                }
                else if (depositSelection == 4)
                {
                    return;
                }
                else
                {
                    Console.WriteLine(depositSelection + "This is not an option. Returning to Main Menu");
                }
            }
            catch (FormatException dm)
            {
                Console.WriteLine("This is not an option. Returning to Main Menu");
            }
        }


        static void MainWithdraw()
        {
            Console.WriteLine("  ->[ WITHDRAW MENU ]\n\n    Select an account to withdraw from\n" +
                "    1. Checking\n" +
                "    2. Savings\n" +
                "    3. Reserve\n" +
                "    4. Return to Main Menu");
            try
            {
                int withdrawSelection = int.Parse(Console.ReadLine());
                if (withdrawSelection == 1)
                {
                    Checking.Withdraw();
                }
                else if (withdrawSelection == 2)
                {
                    Savings.Withdraw();
                }
                else if (withdrawSelection == 3)
                {
                    Reserve.Withdraw();
                }
                else if (withdrawSelection == 4)
                {
                    return;
                }
                else
                {
                    Console.WriteLine(withdrawSelection + "This is not an option. Returning to Main Menu");
                }
            }
            catch (FormatException wm)
            {
                Console.WriteLine("This is not an option. Returning to Main Menu");
            }
        }

        static void ClientInfo()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("{0}" +
            "\nMemeber since 2004 " +
            "\nYou have 3 accounts with {1}" +
            "\n\nAddress: \n {2}" +
            "\nPhone Number: {3}", Account.ClientName, Account.BankName, Account.ClientAddress, Account.ClientPhone);
            
            Console.WriteLine("---------------------------------------------");
        }


    }

}

