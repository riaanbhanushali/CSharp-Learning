using System;

namespace polu
{
    class Animals
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animals 
    {
        public override void sound()
        {
            Console.WriteLine("Dog Bark");
        }
    }
    class Cat : Animals
    {
        public override void sound()
        {
            Console.WriteLine("Cat Meow");
        }
    }

    class Program
    {
        public static void Main()
        {
        Dog d = new Dog();
        Cat c = new Cat();

        d.sound();
        c.sound();
        }
    }
}