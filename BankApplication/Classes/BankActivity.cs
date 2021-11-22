using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Classes
{ 

    //Chukwuemeka Emmanuel Obasi
    //Student ID: 23606
   public class BankActivity

    {
        //creating interface
         public interface balance
        {
           void checkBalance(BankAccount bankAccount);
        }

        public interface deposit
        {
            void placeDeposit(BankAccount bankAccount);
        }

        public interface ITransaction
        {
            void InsertTransaction(BankAccount bankAccount, Transaction transaction);

            void ViewTransaction(BankAccount bankAccount);
       }
    }
}
