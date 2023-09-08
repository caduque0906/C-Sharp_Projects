using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Step 1: Create a class named "Example"
    public class Example
    {
        // Step 2: Create a const variable
        public const int MaxValue = 100;

        // Step 3: Create a variable using the keyword "var"
        public var DynamicVariable = "This is a dynamically typed variable";

        // Step 4: Chain two constructors together
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
