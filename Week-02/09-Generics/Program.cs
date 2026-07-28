using System;
using System.Collections.Generic;

namespace GenercisDemo
{
    class Box<T>
    {
        public T Item ;

        public void display()
        {
            Console.WriteLine(Item);
        }
    }
    class Program
    {
        public static void Main()
        {
            Box<string> books = new Box<string>();
            books.Item="RB ka Book";
            books.display();

            Box<int> age = new Box<int>();
            age.Item=19;
            age.display();
        }
    }
}