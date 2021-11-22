using System;

namespace BankApplication.Classes
{
    internal class ConsoleTable
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;

        public ConsoleTable(string v1, string v2, string v3, string v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public object Options { get; internal set; }

        internal void AddRow(TransactionType transactionType, long bankAccountNoFrom, long bankAccountNoTo, decimal transactionAmount, DateTime transactionDate)
        {
            throw new NotImplementedException();
        }
    }
}