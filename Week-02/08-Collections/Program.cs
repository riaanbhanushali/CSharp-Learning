using System;
using System.Collections.Generic;

namespace collectionDemo
{
    class StudentCollection
    {
        public static void Main()
        {
            List<string> Students = new List<string>();

            Students.Add("Riaan");
            Students.Add("Rahul");
            Students.Add("Priya");

            foreach(string s in Students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nRemoving Riaan ");

            Students.Remove("Riaan");

            foreach(string s in Students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nNumber of Students : " +(Students.Count));

        }
    }
}
