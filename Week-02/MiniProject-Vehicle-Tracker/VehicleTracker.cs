using System;

namespace Logistics
{
    class Vehicle
    {
        public virtual void Track()
        {
            Console.WriteLine("Tracking Vehicle");
        }
    }

    class Truck : Vehicle
    {
        public override void Track()
        {
            Console.WriteLine("Tracking Truck");
        }
    }

    class Bike : Vehicle
    {
        public override void Track()
        {
            Console.WriteLine("Tracking Bike");
        }
    }

    class Van : Vehicle
    {
        public override void Track()
        {
            Console.WriteLine("Tracking Van");
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle v1 = new Truck();
            Vehicle v2 = new Bike();
            Vehicle v3 = new Van();

            v1.Track();
            v2.Track();
            v3.Track();
        }
    }
}