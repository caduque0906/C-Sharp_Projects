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
            // Step 3: Instantiate the Calculator class
            MathOperations mathOps = new MathOperations();

            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Call the DivideByTwo methods and display the results
            mathOps.DivideByTwo(userInput);

            // Step 7: Example of using the new method with output parameters
            int num1 = 10;
            int num2 = 3;
            int quotient, remainder;

            mathOps.DivideWithRemainder(num1, num2, out quotient, out remainder);

            Console.WriteLine($"Result of dividing {num1} by {num2}: Quotient = {quotient}, Remainder = {remainder}");


            Console.ReadLine();
        }
    }
}
