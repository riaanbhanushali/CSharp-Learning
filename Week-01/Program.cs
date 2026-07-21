using System;


namespace First
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($"Welcome, {name}!");
    }
}
}