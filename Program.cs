// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Threading.Tasks;
class Assignment2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world!");
        Test.TestVoid();
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

