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
        bool time = true;
        bool test = false;
        BankAccount bankAccount = new BankAccount(0);
        List<Client> clients = new List<Client>();

        for(int i = 0; i < id; i++)
        {
            var c = new Client(id, bankAccount);
            clients.Add(c);
            Thread t = new Thread(new ThreadStart(c.Run));
            t.Start();
        }

        var timer = new Timer(1000);
        timer.Elapsed += (sender, eventArgs) =>
        {
            Console.WriteLine();
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].IsRunning = false;
            }

            Console.WriteLine("Number of transactions: " + bankAccount.numberOfTransations);
            Console.WriteLine($"Number of errors: {bankAccount.Security.NumberOfErrors}");
        };
        timer.Start();

        /*
        while (time)
        {
            timer++;
            if(timer > 10000) 
            {
                time = false;
                test = true;
                break; 
            }
        }
        */

    }

    public static void OnEventExecution(Object? sender, ElapsedEventArgs eventArgs)
    {
        
    }
}

class Test
{
    public static void TestVoid()
    {
        Console.WriteLine("Doing tests!");

        Console.WriteLine("Doing another test!");
    }
}

