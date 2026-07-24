using System ;

namespace Job
{
    class Employee
    {
        public string Name="";
        public int age ;
    }

     class Work()
    {
        public static void Main()
        {
        Employee emp1 = new Employee();

        emp1.Name = "Riaan";
        emp1.age = 21;

        Console.WriteLine(emp1.Name);
        Console.WriteLine(emp1.age);
        }
    }
}