using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First name? ");
        string First = Console.ReadLine();

        Console.WriteLine("What is your Last name? ");
        string Last = Console.ReadLine();

        Console.WriteLine ($"Your name is {First}, {Last} {First}.");
    }
}