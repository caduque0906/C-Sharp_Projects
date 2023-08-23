using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the methods on the instance of the MathOperations class
            mathOps.DivideByTwo(10);
            mathOps.MultiplyByTwo(8);

            // Call the Add method with output parameter
            mathOps.Add(5, 7, out int sum);
            Console.WriteLine($"Sum of 5 and 7: {sum}");

            Console.ReadLine();
        }
    }
}
