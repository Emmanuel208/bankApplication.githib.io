using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Chukwuemeka Emmanuel Obasi
// student ID: 23606
namespace BankApplication.Classes
{
     public class BankAccount
    {
        // creating properties to get and set

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string accNumber { get; set; }
        public string accPin { get; set; }

        public string email { get; set; }

        public string empoyyePin { get; set; }
        public Decimal accBalance { get; set; }

        public Decimal savingBalance { get; set; }

        public Decimal currentBalance { get; set; }

        
        public BankAccount()
        {

        }


        // assigning those properties
        public BankAccount(string firstName, string lastName, string accNumber, string accPin, Decimal savingBalance, Decimal currentBalance)
        {
            this.accBalance = accBalance;
            this.firstName = firstName;
            this.lastName = lastName;
            this.accNumber = accNumber;
            this.accPin = accPin;
            this.savingBalance = savingBalance;
            this.currentBalance = currentBalance;



        }

    }
}
