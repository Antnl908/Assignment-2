using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Security
    {
        List<Stamp> transactionHistory = new List<Stamp>();
        int numberOfErrors;

        public Security()
        {

        }

        public void MakePreTransactionStamp(int id, double amount)
        {
            History.Add(new Stamp(id, amount));
        }
        public void MakePostTransactionStamp(int id, double amount)
        {
            History.Add(new Stamp(id, amount));
        }

        public List<Stamp> History
        {
            get { return transactionHistory; }
            set { transactionHistory = value; }
        }
    }
}
