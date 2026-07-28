
using System;

namespace Interface
{
    interface IAnimal
    {
        void eat();
        void sleep();
        void run();
    }

    class Dog : IAnimal
    {
        public void eat()
        {
            Console.WriteLine("The dog is eating food");
        }
        public void sleep()
        {
            Console.WriteLine("The dog is sleeping");
        }
        public void run()
        {
            Console.WriteLine("The dog is running");
        }
    }

    class Doggo
    {
        public static void Main()
        {
            Dog d = new Dog();

            d.eat();
            d.sleep();
            d.run();
        }
    }
}