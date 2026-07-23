using System;

namespace EmployeeSalary
{
    class SalaryCalculator
    {
        public static void Main()
        {
            Console.WriteLine("Enter your Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            double tax = Taxes(salary);
            Console.WriteLine("Tax deduction : " + tax );

            double shares = Shares(salary);
            Console.WriteLine("Shares Amount : " + shares);

            double TotalInHand = InHand(salary, tax , shares);
            Console.WriteLine("Total Money in Cash : " + (TotalInHand));
        }
        static double Taxes(double salary)
        {
            double tax = 0.05*(salary);
            return tax;
        }
        static double Shares(double salary)
        {
            double shares = 0.4*(salary);
            return shares;
        }
        static double InHand(double salary , double tax, double shares)
        {
            double finalAmount = salary-(tax + shares);
            return finalAmount;
        }
    }
}