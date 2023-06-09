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
        BankAccount bankAccount = new BankAccount(0);
        List<Client> clients = new List<Client>();

        for(int i = 0; i < id; i++)
        {
            var c = new Client(id, bankAccount);
            clients.Add(c);
            Thread t = new Thread(new ThreadStart(c.Run));
        }

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

