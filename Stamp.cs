using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Stamp
    {
        int clientId;
        double balance;
        public Stamp(int clientId, double balance)
        { 
            this.clientId = clientId;
            this.balance = balance;
        }

        public int ClientId
        {
            get { return clientId; }
        }

        public double Balance
        {
            get { return balance; }
        }
    }
}
