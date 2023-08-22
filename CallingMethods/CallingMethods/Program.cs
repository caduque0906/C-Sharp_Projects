using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user for a number
            Console.Write("Enter a number for math operations: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call each method and display the results
            int squared = mathOps.Square(userInput);
            Console.WriteLine($"Square of {userInput}: {squared}");

            int doubled = mathOps.Double(userInput);
            Console.WriteLine($"Double of {userInput}: {doubled}");

            int incremented = mathOps.Increment(userInput);
            Console.WriteLine($"Incremented value of {userInput}: {incremented}");

            Console.ReadLine();
        }
    }
}
