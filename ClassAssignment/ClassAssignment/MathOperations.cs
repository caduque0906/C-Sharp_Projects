using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class MathOperations
    {
        // Step 2: Define a void method to divide a number by 2
        public void DivideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine($"Result of dividing {num} by 2: {result}");
        }

        // Step 4: Create a method with output parameters
        public void DivideWithRemainder(int num1, int num2, out int quotient, out int remainder)
        {
            quotient = num1 / num2;
            remainder = num1 % num2;
        }

        // Step 5: Overload the DivideByTwo method with a double parameter
        public void DivideByTwo(double num)
        {
            double result = num / 2;
            Console.WriteLine($"Result of dividing {num} by 2: {result}");
        }
    }
}
