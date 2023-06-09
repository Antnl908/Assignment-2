using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Client
    {
        private int id;
        private BankAccount bankAccount;
        public double totalAmountTransactioned;
        private bool depositing;

        private bool isRunning;

        private Random random;

        public bool IsRunning { get => isRunning; set => isRunning = value; }

        public Client(int id, BankAccount bankAccount)
        {
            this.id = id;
            this.bankAccount = bankAccount;

            random = new Random();
            depositing = random.Next(2) == 1;
        }

        public void Run()
        {
            isRunning = true;

            while (isRunning)
            {
                double randomAmount = random.NextDouble();
                if (depositing)
                {
                    bankAccount.Transaction(randomAmount, id);
                    totalAmountTransactioned += randomAmount;
                }
                else
                {
                    bankAccount.Transaction(-randomAmount, id);
                    totalAmountTransactioned -= randomAmount;
                }
            }
        }
    }
}