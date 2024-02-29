using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class TransactionHistory
    {
        public TransactionHistory() { }
        public TransactionHistory(decimal transaction, DateTime date, string cardNum)
        {
            Transaction = transaction;
            Date = date;
            CardNum = cardNum;
        }
        public decimal Transaction { get; set; }
        public DateTime Date { get; set; }
        public string CardNum { get; set; }
    }
}
