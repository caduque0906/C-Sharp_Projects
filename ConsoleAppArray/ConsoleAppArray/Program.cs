using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Grape" };

            // Ask the user to select an index and display the corresponding string
            Console.WriteLine("Select an index for the string array (0-4):");
            int indexStringArray = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the valid range
            if (indexStringArray >= 0 && indexStringArray < stringArray.Length)
            {
                Console.WriteLine($"String at index {indexStringArray}: {stringArray[indexStringArray]}");
            }
            else
            {
                Console.WriteLine("Selected index does not exist in the array.");
            }

            // Create an array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index and display the corresponding integer
            Console.WriteLine("\nSelect an index for the integer array (0-4):");
            int indexIntArray = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the valid range
            if (indexIntArray >= 0 && indexIntArray < intArray.Length)
            {
                Console.WriteLine($"Integer at index {indexIntArray}: {intArray[indexIntArray]}");
            }
            else
            {
                Console.WriteLine("Selected index does not exist in the array.");
            }

            // Create a list of strings
            List<string> stringList = new List<string> { "Alpha", "Beta", "Gamma", "Delta", "Epsilon" };

            // Ask the user to select an index and display the content at that index
            Console.WriteLine("\nSelect an index for the string list (0-4):");
            int indexStringList = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the valid range
            if (indexStringList >= 0 && indexStringList < stringList.Count)
            {
                Console.WriteLine($"Content at index {indexStringList}: {stringList[indexStringList]}");
            }
            else
            {
                Console.WriteLine("Selected index does not exist in the list.");

            }
            Console.ReadLine();
        }
    }
}
