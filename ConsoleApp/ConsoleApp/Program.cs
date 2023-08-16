using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparison using a while statement
            Console.WriteLine("Boolean comparison using a while statement:");
            int counterWhile = 0;  // Initialize counter
            while (counterWhile < 5)  // Loop while counter is less than 5
            {
                Console.WriteLine($"Counter: {counterWhile}");
                counterWhile++;  // Increment counter
            }

            // Boolean comparison using a do while statement
            Console.WriteLine("Boolean comparison using a do while statement:");
            int counterDoWhile = 0;  // Initialize counter
            do
            {
                Console.WriteLine($"Counter: {counterDoWhile}");
                counterDoWhile++;  // Increment counter
            } while (counterDoWhile < 5);  // Loop while counter is less than 5
            Console.ReadLine();
        }
    }
}
