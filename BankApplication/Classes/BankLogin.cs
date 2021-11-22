using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Classes
{
    //Chukwuemeka Emmanuel Obasi
    // student ID: 23606
    public class BankLogin
       {
      
        /// <summary>
        /// created a class bankLogin to get the visual look of the application and any giving time in the code
        /// 
        ///
        /// </summary>
        public static class Screen
        {
            internal static string cur = "$";
        }
      

        public static void showMenu1()
        {
            
            Console.Clear();
            Console.WriteLine(" ------------------------------");
            Console.WriteLine("| Bank Of Emmanuel Main Menu  |");
            Console.WriteLine("|                             |");
            Console.WriteLine("| 1. Press 1 for Bank Empoyee |");
            Console.WriteLine("| 2. press 2 for Customer     |");
            Console.WriteLine("|                             |");
            Console.WriteLine(" -----------------------------");
            
        }


       
        public static void showMenu2()
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------");
            Console.WriteLine("|Bank of Emmanuel CustomerMenu  |");
            Console.WriteLine("|                               |");
            Console.WriteLine("| 1. Balance Enquiry            |");
            Console.WriteLine("| 2. Deposit                    |");
            Console.WriteLine("| 3. Withdrawal                 |");
            Console.WriteLine("| 4. Transactions               |");
            Console.WriteLine("| 5. Logout                     |");
            Console.WriteLine("|                               |");
            Console.WriteLine(" -------------------------------");
        }


       
        public static void showMenu3()
        {
            Console.Clear();
            Console.WriteLine(" --------------------------------");
            Console.WriteLine("|Bank of Emmanuel EmpoyeeMenu    |");
            Console.WriteLine("|                                |");
            Console.WriteLine("| 1. Create account              |");
            Console.WriteLine("| 2. Delete account              |");
            Console.WriteLine("| 3. Customer List               |");
            Console.WriteLine("| 4. Transactions                |");
            Console.WriteLine("| 5. Logout                      |");
            Console.WriteLine("|                                |");
            Console.WriteLine(" --------------------------------");

        }


        
        //public static void showMenu4()
        //{
        //    Console.Clear();
        //    Console.WriteLine(" --------------------------------");
        //    Console.WriteLine("|Bank of Emmanuel EmpoyeeMenu    |");
        //    Console.WriteLine("|                                |");
        //    Console.WriteLine("| 1. Create account              |");
        //    Console.WriteLine("| 2. Delete account              |");
        //    Console.WriteLine("| 3. Logout                      |");
        //    Console.WriteLine("|                                |");
        //    Console.WriteLine(" --------------------------------");

        //}

        

    }

    // Menu fuction that lets you pick an option for the menu

    public enum secureMenu
    {
        // Value 1 is needed because menu starts with 1 while enum starts with 0 if no value given.

        [Description("Check balance")]
        checkBalance = 1,

        [Description("Place Deposit")]
        placeDeposit = 2,

        [Description("Make Withdrawal")]
        makeWithdrawal = 3,

        [Description("Transaction")]
        viewTransaction = 4,

        [Description("Logout")]
        Logout = 5
    }

    // Menu fuction that lets you pick an option for the menu
    public enum secureEmpoyeeMenu
    {
        // Value 1 is needed because menu starts with 1 while enum starts with 0 if no value given.

        [Description("Create Accountt")]
        createAccount = 1,

        [Description("Delete Account")]
        deleteAccount = 2,

        [Description("Customer List")]
        customerList = 3,

        [Description("Transction")]
        transction= 4,

        [Description("Logout")]
        logout = 5

    }


}
