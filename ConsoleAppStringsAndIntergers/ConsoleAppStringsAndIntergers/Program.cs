using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntergers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a list of integers
                List<int> numberList = new List<int> { 10, 20, 30, 40, 50 };

                // Ask the user for a number to divide each number in the list by
                Console.Write("Enter a number to divide each number in the list by: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                // Loop to perform division and display results
                for (int i = 0; i < numberList.Count; i++)
                {
                    int result = numberList[i] / divisor; // Division operation
                    Console.WriteLine($"Result at index {i}: {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                // Catch and display DivideByZeroException error
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                // Catch and display FormatException error
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Code to execute after the try/catch block
                Console.WriteLine("The program has emerged from the try/catch block and continued execution.");
            }

            Console.ReadLine();
        }
    }
}
