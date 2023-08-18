using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of strings with at least two identical strings
            List<string> stringList = new List<string> { "A", "B", "C", "D", "C" };

            // Create a dictionary to keep track of string occurrences
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            // Loop to evaluate each item in the list using a foreach loop
            foreach (string item in stringList)
            {
                // Check if the item is already in the dictionary
                if (occurrences.ContainsKey(item))
                {
                    occurrences[item]++;  // Increment the count if it's a duplicate
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    occurrences[item] = 1;  // Add the item to the dictionary with a count of 1
                    Console.WriteLine($"{item} - this item is unique");
                }
            }
            Console.ReadLine();
        }
    }
}
