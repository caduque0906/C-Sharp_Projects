using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to input two numbers
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number (leave empty if not entering): ");
            string input = Console.ReadLine();
            int num2 = string.IsNullOrEmpty(input) ? 0 : Convert.ToInt32(input);

            // Call the method and display the result
            int result = mathOps.PerformMath(num1, num2);
            Console.WriteLine($"Result of PerformMath: {result}");

            Console.ReadLine();
        }
    }
}
