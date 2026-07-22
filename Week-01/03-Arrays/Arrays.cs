using System ;
using System.Collections.Generic;

namespace Arrays
{
    class Arrays
    {
        public static void Main()
        {
            Arrays.dictionaries();   
        }
            public static void inputArray()
            {
                 int[] num = {4 , 5 , 6 , 7 , 8};

            for(int i =0 ; i<5 ; i++)
            {
                Console.Write(num[i] + " ");
            }
            }

            public static void UserinpArray()
            {
                  int[] test = new int[5];

            for(int i=0 ; i<test.Length ; i++)
            {
                Console.WriteLine("Enter your marks : ");
                test[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(test[4]);

            int j=0;
            foreach (int t in test)
            {
                j++;
            }
            Console.WriteLine(j);
            }

            public static void lists()
            {
                List<int> numbers = new List<int>();

                numbers.Add(10);
                numbers.Add(20);
                numbers.Add(30);


                for(int i=0 ; i<numbers.Count ; i++)
            {
                Console.WriteLine(numbers[i]);
            }

             numbers.Remove(30);

            Console.WriteLine("Now we check if 30 is removed :");
             foreach(int num in numbers )
            {
                Console.WriteLine(num);
            }

            numbers.Add(90);
            numbers.Add(110);

             foreach(int num in numbers )
            {
                Console.WriteLine(num);
            }
             Console.WriteLine("Now we check if added :");
            numbers.RemoveAt(2);

            numbers.Insert(1,69);

             Console.WriteLine("Now we check if removed and inserted :");

             foreach(int num in numbers )
            {
                Console.WriteLine(num);
            }        
            }
            public static void dictionaries()
            {
                Dictionary<int,string> marks = new Dictionary<int, string>();

                marks.Add(101, "Riaan");
                marks.Add(102, "Harsh");
                marks.Add(103, "Aasvi");

                Console.WriteLine(marks[101]);

                marks.Remove(102);

                marks[103]="HARSH";

                if(marks.ContainsKey(102))
            {
                Console.WriteLine("Present");
            }

                Console.WriteLine(marks[103]);

                if(marks.ContainsValue("HARSH"))
                {
                Console.WriteLine("Harsh is present");
            }

            marks.Clear();

            Console.WriteLine(marks.Count);

            }
        }

    }

