using System ;

namespace inheritance
{
    class Parent
    {
        public void Eyes()
        {
            Console.WriteLine("I have brown eyes");
        }
        public void Nose()
        {
            Console.WriteLine("I have a big nose ");
        }
    }

    class Child : Parent
    {
        public void height()
        {
            Console.WriteLine("I am Tall");
        }
    }
    
    class Family
    {
        public static void Main()
        {
            Child c1 = new Child();
            c1.Eyes();
            c1.Nose();
            c1.height();


        }
    }
}