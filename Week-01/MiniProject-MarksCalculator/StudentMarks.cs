using System ;

namespace MarksCalculator
{
    class Calc
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of Subjects");
            int n = Convert.ToInt32(Console.ReadLine());

             int[] marks = new int[n];

             Console.WriteLine("Enter the Marks");

            InputMarks(marks);

            int total = CalculateMarks(marks);

            Console.WriteLine("Total : " + (CalculateMarks(marks)));

            Console.WriteLine("Average : " + (CalculateAverage(total ,marks)) );



        }

        public static void InputMarks(int[] marks)
        {
            for(int i=0 ; i<marks.Length ; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static int CalculateMarks(int[] marks)
        {
            int total = 0 ;
            for(int i=0 ; i<marks.Length ; i++)
            {
                total += marks[i];
            }
            return total;
        }

        public static double CalculateAverage(int total , int[] marks)
        {
            double average = ((double)total/(marks.Length));
            return average;
        }
    }
}