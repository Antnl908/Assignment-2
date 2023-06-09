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

        public void VerifyLastTransaction(double amount)
        {
            double sum =0 ;
            //for (int i = 0; i < History.Count; i ++)
            //{
            //    //sum += History[i + 1].Balance - History[i].Balance;
            //    for(int j = i; j < History.Count; j ++)
            //    {

            //    }
            //}


            //sum = History[History.Count - 1].Balance - History[History.Count - 2].Balance;

            if(sum != amount) { numberOfErrors++; }

            //Console.WriteLine($"Final amount: {amount} Expected amount {sum} Number of errors: {numberOfErrors}");
        }

        public List<Stamp> History
        {
            get { return transactionHistory; }
            set { transactionHistory = value; }
        }

        public int NumberOfErrors
        {
            get { return numberOfErrors; }
        }
    }
}
