using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices.Marshalling;

namespace Methods
{
class Program
{
    static void Main(string[] args)
    {
        Greet();
        animal();
        sum(4,5);
        namesay("riaan");

         int answer = addition(5,10);
         Console.WriteLine(answer);

         string namecalling = namecall();
         Console.WriteLine(namecalling);

         bool result = ans(15);
         Console.WriteLine(result);
    }

    static void Greet()
    {
        Console.WriteLine("Welcome to C#");
    }

    static void animal()
        {
            Console.WriteLine("Dog");
        }

        static void sum(int x,int y)
        {
            Console.WriteLine(x+y);
        }

        static void namesay(string name)
        {
            Console.WriteLine("Your name is "+name);
        }

        static int addition(int x , int y )
        {
            return x+y;
        }

        static string namecall()
        {
            return "Harsh";
        }

        static bool ans(int ages)
        {
            return ages<=18;
        }
}
}