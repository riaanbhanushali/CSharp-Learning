
using System;

namespace Constructors
{
    class Employee
    {
        public string Name = "";
        public int Age;

        public Employee()
        {
            Console.WriteLine("Constructor Executed");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee();
        }
    }
}