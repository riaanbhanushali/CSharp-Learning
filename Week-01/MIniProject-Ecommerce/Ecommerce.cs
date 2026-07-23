using System;

namespace Ecommerce
{
    class Ecommerce
    {
        public static void Main()
        {
            Console.Write("Enter the Cost of item:");
            double ItemCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Amount of Quantity: ");
            int Amount = Convert.ToInt32(Console.ReadLine());

            double total = TotalCost(Amount,ItemCost);
            Console.WriteLine("Cost (Before Tax): " + total);

             double tax = Tax(total);
            Console.WriteLine("Tax: " + tax);

            Console.WriteLine("Final Cost: " + (total+tax));

        }

        static double TotalCost(int Amount , double ItemCost)
        {
            double total = Amount*ItemCost;
            return total;
        }

        public static double Tax(double total)
        {
            double tax = total*0.05;
            return tax;
        } 
    }
}