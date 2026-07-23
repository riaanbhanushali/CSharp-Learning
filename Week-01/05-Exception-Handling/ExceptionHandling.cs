using System ;
using System.Collections.Generic;

namespace ExcHandling
{
    class ExcHandling
    {
        public static void Main()
        {
            // ExcHandling.catchblock();
            // ExcHandling.catchException();
           // ExcHandling.gettype();
           // ExcHandling.ErrorLine();
            //ExcHandling.throwE();

        }

        public static void catchblock()
        {
            
            try
            {
            int a = 10;
            int b = 0;

            Console.WriteLine(a/b);
            }
            catch
            {
                Console.WriteLine("Something went wrong .");
            }
        }

        public static void catchException()
        {
            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a/b);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

         public static void gettype()
        {
            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a/b);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
        }

         public static void ErrorLine()
        {
            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a/b);
            }
           /*  catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }*/

            catch(DivideByZeroException) //SPECIFIC EXCEPTION
            {
                Console.WriteLine("Cannot be divided by zero");
            }
            finally
            {
                Console.WriteLine("Inside FINALLY");
            }
        }

        public static void throwE()
        {
            int age = -5;

            if(age<0)
            {
                throw new Exception("Age cannot be negative");
            }
        }



    }
}