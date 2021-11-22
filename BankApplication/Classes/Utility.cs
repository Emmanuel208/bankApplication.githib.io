using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankApplication.Classes

  {
    //Chukwuemeka Emmanuel Obasi
    // student ID: 23606

    public interface IBalance
    {
        void CheckBalance(BankAccount bankAccount);
    }

    public interface IWithdrawal
    {
        void MakeWithdrrawal(BankAccount bankAccount);
           
    }

    public interface IDeposit
    {
        void PlaceDeposit(BankAccount bankAccount);
    }

    public interface ITransction
    {
        void InserTransaction(BankAccount bankAccount, Transaction transaction);

        void ViewTransaction(BankAccount bankAccount);
    }

    public interface ILogin
    {
        void CheckAccount();
    }



    /// <summary>
    /// use utility class to get system fuctions and impliment them in nmain code 
    /// </summary>
    public static class Utility
    {
   
        private static CultureInfo culture = new CultureInfo("en-US");
        private static List<BankAccount> detailsList;




        public static string getOptionMainMenu(string input)
        {

            string pin = "A1234";
            string message = "welcome";
            
            Console.WriteLine("Enter your Empoyee pin");
                do
                {
                      pin = Console.ReadLine();
                    if (pin == "A1234")
                    {
                        Console.WriteLine($"{message}");


                    }
                    else
                    {
                        Console.WriteLine("Invalid input try again");
                    }

                } while (pin != "A1234");

                  return message;

        }

        public static string getOptionMainMenu2(string input)
        {
            string message = " Welcome, please enter your full name, account number and pin ";

             Console.WriteLine(message);
            
 return message;
        }


        public static Int64 GetValidInputCustomerMenu(string input)
        {
           


             bool valid = false;
             string rawInput;
             Int64 amount = 0;

             //Get user's input input type is valid
             while (!valid)
             {
                 rawInput = getRawInput(input);
                 valid = Int64.TryParse(rawInput, out amount);
                 if (!valid)
                     Console.WriteLine("Invalid input. Try again.", false);
             }

            return (amount);



        }

        public static Int64 GetValidInputEmpoyyeMenu(string input)
        {
            bool valid = false;
            string rawInput;
            Int64 amount = 0;

            // Get user's input input type is valid
            while (!valid)
            {
                rawInput = getRawInput(input);
                valid = Int64.TryParse(rawInput, out amount);
                if (!valid)
                    Console.WriteLine("Invalid input. Try again.", false);
            }

            return amount;



        }

        public static string getRawInput(string message)
        {
            Console.Write($"Enter {message}: ");
            return Console.ReadLine();
        }



      

        #region UIOutput - UX and output format
        public static void  printDotAnimation(int timer = 10)
        {
            for (var x = 0; x < timer; x++)
            {
                System.Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }

        public static string FormatAmount(decimal amt)
        {
            return String.Format(culture, "{0:C2}", amt);
        }

        public static void printMessage(string msg, bool success)
        {
            if (success)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(msg);
            Console.ResetColor();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        #endregion

        public static decimal GetValidDecimalInputAmt(string input)
        {
            bool valid = false;
            string rawInput;
            decimal amount = 0;

            // Get user's input input type is valid
            while (!valid)
            {
                rawInput = getRawInput(input);
                valid = decimal.TryParse(rawInput, out amount);
                if (!valid)
                    PrintMessage("Invalid input. Try again.", false);
            }

            return amount;
        }

        public static void PrintMessage(string msg, bool success)
        {
            if (success)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(msg);
            Console.ResetColor();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        public static Int64 GetValidIntInput(string input)
        {
            bool valid = false;
            string rawInput;
            Int64 amount = 0;

            // Get user's input input type is valid
            while (!valid)
            {
                rawInput = getRawInput(input);
                valid = Int64.TryParse(rawInput, out amount);
                if (!valid)
                    PrintMessage("Invalid input. Try again.", false);
            }

            return amount;
        }

        internal static object FormatAmount(Transaction transaction_amt)
        {
            return String.Format(culture, "{0:C2}", transaction_amt);
        }
    }
}
