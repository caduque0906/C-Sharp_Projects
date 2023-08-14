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


            // Get details for Person 2
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate? ");
            double hourlyRatePerson2 = Convert.ToDouble(Console.ReadLine());  // Get hourly rate as a double
            Console.Write("Hours worked per week? ");
            double hoursWorkedPerWeekPerson2 = Convert.ToDouble(Console.ReadLine());  // Get hours worked per week as a double


            // Calculate annual salaries for both persons
            double annualSalaryPerson1 = hourlyRatePerson1 * hoursWorkedPerWeekPerson1 * 52;
            double annualSalaryPerson2 = hourlyRatePerson2 * hoursWorkedPerWeekPerson2 * 52;

            // Print annual salaries
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalaryPerson1.ToString("N"));  // Display salary with thousands separator
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalaryPerson2.ToString("N"));  // Display salary with thousands separator

            // Check if Person 1 makes more money than Person 2
            bool person1MakesMore = annualSalaryPerson1 > annualSalaryPerson2;

            // Print the comparison result
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1MakesMore);
            Console.ReadLine();
        }
    }
}
