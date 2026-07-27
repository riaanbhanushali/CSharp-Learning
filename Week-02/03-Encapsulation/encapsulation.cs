using System ;
using System.Collections.Generic ;

namespace enscapsulation
{
    class Encap
    {
        private string name;
        private int age ;

        public Encap(string Name , int Age)
        {
            name = Name ;
            age = Age;
        }

        public void display()
        {
            Console.WriteLine(name+":"+age);
        }

        static void Main()
        {
            Encap p1 = new Encap("Riaan", 19);
            p1.display();
        }
    }
}