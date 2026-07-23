using System ;
using System.Collections.Generic;

namespace HospitaQueueDemo
{
    class HospitalQueue
    {
        public static void Main()
        {
            Queue<string> Patients = new Queue<string>();
            Patients.Enqueue("Riaan");
            Patients.Enqueue("Dev");
            Patients.Enqueue("Harsh");

            Console.WriteLine("Now Serving : " + Patients.Dequeue());

            foreach(string p in Patients)
            {
            Console.WriteLine(p);
            }

        }
    }
}