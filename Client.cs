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
        private double totalAmountTransactioned;
        private bool depositing;

        private bool isRunning;

        private Random random;

        public bool IsRunning { get => isRunning; set => isRunning = value; }
        public int Id { get => id; }

        public Client(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;

            random = new Random();

            depositing = random.Next(2) == 1;
        }

        public void Run()
        {
            isRunning = true;

            while (isRunning)
            {
                double randomAmount = random.NextDouble() * 100;
                if (depositing)
                {
                    //bankAccount.Deposit(-randomAmount);
                    totalAmountTransactioned += randomAmount;
                }
                else
                {
                    //bankAccount.Deposit(randomAmount);
                    totalAmountTransactioned -= randomAmount;
                }
            }
        }
    }
}

