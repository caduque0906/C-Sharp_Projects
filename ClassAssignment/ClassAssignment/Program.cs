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

            // Ask the user to enter a number
            Console.Write("Enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            // Call the DivideByTwo methods and display the results
            mathOps.DivideByTwo(userInput);

            // Declare a static class (no instantiation needed)
            StaticClass.StaticMethod();

            Console.ReadLine();
        }
    }
}
