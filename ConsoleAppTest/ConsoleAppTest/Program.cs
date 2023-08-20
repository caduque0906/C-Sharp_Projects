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
            // Create an array of strings
            string[] stringArray = { "Hello", "World", "C#", "Programming", "Array" };

            // Ask the user to input some text
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();

            // Loop to append user's text to each string in the array
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput; // Append user's text to the current string
            }

            Console.WriteLine("Updated strings in the array with user's text.\n");

            // Loop to print each string in the array
            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            // Infinite loop
            // Fix: To avoid an infinite loop, we can add a condition to exit the loop.
            bool exitLoop = false;
            while (!exitLoop)
            {
                Console.WriteLine("This is an infinite loop. Type 'exit' to break.");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    exitLoop = true;  // Exiting the loop
                }
            }

            Console.ReadLine();

            // Loop using "<" comparison
            Console.WriteLine("\nLoop with < comparison:");
            for (int i = 0; i < 5; i++)  // Loop while i is less than 5
            {
                Console.WriteLine($"i = {i}");
            }

            // Loop using "<=" comparison
            Console.WriteLine("\nLoop with <= comparison:");
            for (int i = 0; i <= 5; i++)  // Loop while i is less than or equal to 5
            {
                Console.WriteLine($"i = {i}");
            }

            Console.ReadLine();

            // Create a list of unique strings
            List<string> stringList = new List<string> { "Apple", "Banana", "Cherry", "Date", "Grape" };

            // Ask the user to input text to search for
            Console.Write("Enter text to search for: ");
            string searchText = Console.ReadLine();

            bool found = false;  // Flag to indicate if a match has been found

            // Loop to iterate through the list
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Contains(searchText))
                {
                    Console.WriteLine($"Match found at index {i}");
                    found = true;  // Match found, set flag to true
                    break;  // Stop the loop
                }
            }

            // Check if a match was not found
            if (!found)
            {
                Console.WriteLine("Input is not on the list.");
            }

            Console.ReadLine();
        }
    }
}
