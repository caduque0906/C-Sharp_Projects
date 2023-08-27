using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    // Enum to represent the days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert user input to the DaysOfWeek enum
                DaysOfWeek currentDay;
                bool parseSuccess = Enum.TryParse(userInput, out currentDay);

                if (!parseSuccess)
                {
                    throw new Exception("Invalid day input");
                }

                // Print the current day
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
