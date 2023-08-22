using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method and pass in two numbers
            mathOps.DisplayMathResult(5, 10);

            // Call the method and specify parameters by name
            mathOps.DisplayMathResult(num1: 8, num2: 15);

            Console.ReadLine();
        }
    }
}
