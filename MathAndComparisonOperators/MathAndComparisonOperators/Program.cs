using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the program header
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get details for Person 1
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            double hourlyRatePerson1 = Convert.ToDouble(Console.ReadLine());  // Get hourly rate as a double
            Console.Write("Hours worked per week? ");
            double hoursWorkedPerWeekPerson1 = Convert.ToDouble(Console.ReadLine());  // Get hours worked per week as a double
        }
    }
}
