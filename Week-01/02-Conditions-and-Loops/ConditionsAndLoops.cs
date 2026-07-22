using System;

namespace conditionsandloops
{
    class Program
    {
        public static void Main(string[] args)
        {
            //if if-else loops 
            
            Console.WriteLine("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age<=18)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            //switch
            Console.WriteLine("Enter Day Number");
            int day =Convert.ToInt32(Console.ReadLine());
            switch(day)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                    default:
                        Console.WriteLine("Not Monday");
                        break;
            }

            //for loop 

            for(int k=0 ; k<=5 ; k++)
            {
                Console.WriteLine(k);
                
            }
            Console.WriteLine("FOR LOOP");

            //while-loop

            int i=0;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("WHILE LOOP");

            //while-do loop 

            int j=10;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while(j<=20);
            Console.WriteLine("DO-WHILE LOOP");

        }
    }
}