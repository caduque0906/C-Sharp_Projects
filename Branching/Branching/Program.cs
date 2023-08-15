using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            // Print the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Get package weight from user input
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;  // End the program
            }

            // Get package dimensions from user input
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if dimensions exceed 50
            double dimensionsTotal = width + height + length;
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;  // End the program
            }

            // Calculate the shipping quote
            double quote = (width * height * length * weight) / 100;

            // Display the quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
            Console.ReadLine();

        }
    }
}
