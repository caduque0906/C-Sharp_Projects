using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class MathOperations
    {
        public class MathOperations
        {
            public void DivideByTwo(int number)
            {
                // Divide the number by 2 and display the result
                int result = number / 2;
                Console.WriteLine($"Result of division by 2: {result}");
            }

            public void MultiplyByTwo(int number)
            {
                // Multiply the number by 2 and display the result
                int result = number * 2;
                Console.WriteLine($"Result of multiplication by 2: {result}");
            }

            public void Add(int num1, int num2, out int sum)
            {
                // Add two numbers and assign the sum to the output parameter
                sum = num1 + num2;
            }
        }
    }
}
