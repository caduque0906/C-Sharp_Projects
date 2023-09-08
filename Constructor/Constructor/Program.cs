using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Example class
            Example example = new Example();

            // Access the constant variable
            Console.WriteLine($"Max Value: {Example.MaxValue}");

            // Access the dynamically typed variable
            Console.WriteLine(example.DynamicVariable);

            Console.ReadLine();
        }
    }
}
