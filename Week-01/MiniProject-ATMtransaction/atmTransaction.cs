using System;

class Program
{
    static double balance = 10000;

    static void Main()
    {
        bool exit = false;

        while(!exit)
        {
            Console.WriteLine("\n1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Check Balance");
            Console.WriteLine("4.Exit");

            Console.Write("Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Deposit();
                    break;

                case 2:
                    Withdraw();
                    break;

                case 3:
                    CheckBalance();
                    break;

                case 4:
                    exit=true;
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    static void Deposit()
    {
        Console.Write("Amount: ");
        double amount=Convert.ToDouble(Console.ReadLine());

        balance+=amount;
    }

    static void Withdraw()
    {
        Console.Write("Amount: ");
        double amount=Convert.ToDouble(Console.ReadLine());

        if(amount<=balance)
            balance-=amount;

        else
            Console.WriteLine("Insufficient Balance");
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Balance = {balance}");
    }
}