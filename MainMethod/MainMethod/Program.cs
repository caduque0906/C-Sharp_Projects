using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer parameter
            int result1 = mathOps.PerformMath(5);
            Console.WriteLine($"Result of PerformMath with integer: {result1}");

            // Call the second method with a decimal parameter
            int result2 = mathOps.PerformMath(16.25m);
            Console.WriteLine($"Result of PerformMath with decimal: {result2}");

            // Call the third method with a string parameter
            int result3 = mathOps.PerformMath("20");
            Console.WriteLine($"Result of PerformMath with string: {result3}");

            Console.ReadLine();
        }
    }
}
