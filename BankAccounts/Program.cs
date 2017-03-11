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

            Checking myChecking = new Checking();


            int userInput = 0;
            do
            {

                userInput = MainMenu();

                switch (userInput)
                {
                    case 1:

                        //myChecking.ShowMenu();
                        break;
                    case 2:
                        //mySavings.ShowMenu();
                        break;
                    case 3:
                        MainDeposit();
                        
                        break;
                    case 4:
                        MainWithdraw();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using Fat Stacks Banking.");
                        //Checking.SendLog();
                        //System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That was not an available option");

                        break;
                }


            } while (userInput != 5);

            System.Environment.Exit(0);




        }
         static int MainMenu()
        {
            
            Savings mySavings = new Savings();
            Reserve myReserve = new Reserve();
            Account myAccount = new Account();
           // Console.WriteLine("Hi " + myAccount.ClientName + "\n");

            Console.WriteLine("\nWelcome to Fat Stacks Banking!\n\n[ MAIN MENU ]\n\n Please select from the following options\n" +
                "  1. View Profile\n" +
                "  2. Account Balance\n" +
                "  3. +Deposit Funds\n" +
                "  4. +Withdraw Funds\n" +
                "  5. Exit");

            int selection = int.Parse(Console.ReadLine());
            return selection;
          /*  switch (selection)
            {
                case 1:
                    
                    //myChecking.ShowMenu();
                    break;
                case 2:
                    //mySavings.ShowMenu();
                    break;
                case 3:
                    
                    //myReserve.ShowMenu();
                    break;
                case 4:
                    Checking.Withdraw();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using Fat Stacks Banking.");

                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That was not an available option");

                    break;
            } */
        }



        static void MainDeposit()
        {
            Console.WriteLine("  -[ DEPOSIT MENU ]\n\n   Select an account to deposit to\n" +
                "   1. Checking\n"+
                "   2. Savings\n" +
                "   3. Reserve\n" +
                "   4. Return to Main Menu");

            int withdrawSelection = int.Parse(Console.ReadLine());
            if (withdrawSelection == 1)
            {
                Checking.Deposit();
            }
            else if (withdrawSelection == 2)
            {
                Savings.Deposit();
            }else if(withdrawSelection == 3)
            {
                Reserve.Deposit();
            }else if( withdrawSelection == 4)
            {
                return;
            }
            else
            {
                Console.WriteLine(withdrawSelection + " is not an option. Returning to Main Menu");
            }
        }


        static void MainWithdraw()
        {
            Console.WriteLine("Select an account to withdraw from\n 1. Checking\n 2. Savings\n 3. Reserve\n 4. Return to Main Menu");
            int withdrawSelection = int.Parse(Console.ReadLine());
            if (withdrawSelection == 1)
            {
                Checking.Withdraw();
            }else if (withdrawSelection == 2)
            {
                Savings.Withdraw();
            }else if(withdrawSelection == 3)
            {
                Reserve.Withdraw();
            }else if(withdrawSelection == 4)
            {
                return;
            }else
            {
                Console.WriteLine(withdrawSelection + " is not an option. Returning to Main Menu");
            }
        }


    }

}

