// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Assignment_2;
using System;
using System.Threading.Tasks;
class Assignment2
{
    static void Main(string[] args)
    {
        int id = 10;
        int timer = 0;
        bool time = true;
        BankAccount bankAccount = new BankAccount(0);
        List<Client> clients = new List<Client>();

        for(int i = 0; i < id; i++)
        {
            var c = new Client(id, bankAccount);
            clients.Add(c);
            Thread t = new Thread(new ThreadStart(c.Run));
        }

        while(time)
        {
            timer++;
            if(timer > 40) { time = false; break; }
        }

        for(int i = 0; i < clients.Count; i++)
        {
            clients[i].IsRunning = false;
        }

        Console.WriteLine($"Numer of errors{bankAccount.Security.NumberOfErrors}");

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

