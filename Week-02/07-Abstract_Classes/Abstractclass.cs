using System;

namespace AbstractExample
{
    abstract class Employee
    {
        public void Login()
        {
            Console.WriteLine("Employee Logged In");
        }

        public abstract void Work();
    }

    class Developer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Writing Code");
        }
    }

    class Tester : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Testing Application");
        }
    }

    class Program
    {
        static void Main()
        {
            Developer dev = new Developer();

            dev.Login();
            dev.Work();

            Console.WriteLine();

            Tester tester = new Tester();

            tester.Login();
            tester.Work();
        }
    }
}