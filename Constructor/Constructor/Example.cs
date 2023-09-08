using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Create a class named "Example"
    public class Example
    {
        // Create a const variable
        public const int MaxValue = 100;

        // Create a variable using the keyword "var"
        public var DynamicVariable = "This is a dynamically typed variable";

        // Chain two constructors together
        public Example()
            : this("Default Constructor")
        {
        }

        public Example(string message)
        {
            Console.WriteLine(message);
        }
    }
}
