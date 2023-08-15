using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the program header
            Console.WriteLine("Car Insurance Approval Program");

            // Get applicant's age
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask about DUI
            Console.Write("Have you ever had a DUI? (true/false) ");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // Get number of speeding tickets
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            // Check qualification rules
            bool qualifies = (age > 15) && !hasDUI && (speedingTickets <= 3);

            // Print qualification result
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualifies);
            Console.ReadLine();
        }
    }
}
