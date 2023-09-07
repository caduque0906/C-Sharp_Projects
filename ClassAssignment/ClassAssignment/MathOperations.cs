using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class MathOperations
    {
        // Define a void method to divide a number by 2
        public void DivideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine($"Result of dividing {num} by 2: {result}");
        }

        // Overload the DivideByTwo method with a double parameter
        public void DivideByTwo(double num)
        {
            double result = num / 2;
            Console.WriteLine($"Result of dividing {num} by 2: {result}");
        }
    }
}
