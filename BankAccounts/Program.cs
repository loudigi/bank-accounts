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

            
            MainMenu();
           
            
            
        


    }
        private static void MainMenu()
        {
            Checking myChecking = new Checking();
            Savings mySavings = new Savings();
            Reserve myReserve = new Reserve();
            Account myAccount = new Account();
            Console.WriteLine("Hi " + myAccount.ClientName + "\n");

            Console.WriteLine("\n Welcome to Fat Stacks Banking!\nPlease select from the following options\n" +
                "1. Checking\n" +
                "2. Savings\n" +
                "3. Reserve\n" +
                "4. Balance Dashboard\n" +
                "5. Exit");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    myChecking.ShowMenu();
                    break;
                case 2:
                    mySavings.ShowMenu();
                    break;
                case 3:
                    myReserve.ShowMenu();
                    break;
                case 4:

                    break;
                case 5:
                    Console.WriteLine("Thank you for using Fat Stacks Banking.");
                    
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("That was not an available option");

                    break;
            }
        }

       

    }
}

