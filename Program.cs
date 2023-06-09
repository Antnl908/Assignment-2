// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Assignment_2;
using System;
using System.Threading.Tasks;
using System.Timers;
using System.Transactions;
using Timer = System.Timers.Timer;

class Assignment2
{
    static void Main(string[] args)
    {
        int id = 5;
        //int timer = 0;
        BankAccount bankAccount = new BankAccount(0);
        List<Client> clients = new List<Client>();

        double amountTotal = 0;

        for (int i = 0; i < id; i++)
        {
            var c = new Client(id, bankAccount);
            clients.Add(c);
            Thread t = new Thread(new ThreadStart(c.Run));
            t.Start();
        }

        var timer = new Timer(1000);
        timer.Elapsed += (sender, eventArgs) =>
        {
            Console.WriteLine("Number of transactions: " + bankAccount.numberOfTransations);
            Console.WriteLine("Number of errors: " + bankAccount.Security.NumberOfErrors);

            foreach (Client client in clients)
                amountTotal += client.totalAmountTransactioned;

            Console.WriteLine("All transactions of clients sums into: " + amountTotal + ", balance on account: " + bankAccount.balance);

            Console.WriteLine();
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].IsRunning = false;
            }
        };
        timer.Start();

        
    }
}
