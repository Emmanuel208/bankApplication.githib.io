using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Classes
{
    //Chukwuemeka Emmanuel Obasi
    // student ID: 23606
    public class Transaction
    {
        public int TransactionId { get; set; }

        public  string BankAccountNoFrom { get; set; }


        public Int64 BankAccountNoTo { get; set; }

        public TransactionType TransactionType { get; set; }
        public decimal TransactionAmount { get; set; }


        public DateTime TransactionDate { get; set; }
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal
        
    }
}
