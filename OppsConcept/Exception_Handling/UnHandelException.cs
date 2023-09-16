using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    using System;

    class UnHandelException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Main method: Start");
                UnhandledExceptionMethod();
                Console.WriteLine("Main method: End");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Main method: Caught an exception: {ex.Message}");
            }
        }

        static void UnhandledExceptionMethod()
        {
            Console.WriteLine("UnhandledExceptionMethod: Start");

            // This line will throw an unhandled exception
            int result = 10;

            Console.WriteLine("UnhandledExceptionMethod: End");
        }
    }

}
