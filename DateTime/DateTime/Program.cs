using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Print the current date and time to the console
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"Current date and time: {currentDateTime}");

            // Step 2: Ask the user for a number
            Console.Write("Enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Step 3: Calculate and print the time in X hours
            DateTime futureDateTime = currentDateTime.AddHours(userNumber);
            Console.WriteLine($"In {userNumber} hours, it will be: {futureDateTime}");

            Console.ReadLine();
        }
    }
}
