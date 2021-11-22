using BankApplication.Classes;
using System;

namespace BankApplication
{
    //Chukwuemeka Emmanuel Obasi
    // student ID: 23606
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Application");

            Driver emm = new Driver();
           // emm.AccountList();
            emm.run();
            
        }
    }
}
