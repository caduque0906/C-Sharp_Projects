using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathOperations
    {
        public int PerformMath(int number)
        {
            // Perform some math operation on the integer
            // For this example, let's double the number
            return number * 2;
        }

        public int PerformMath(decimal number)
        {
            // Perform a different math operation on the decimal
            // For this example, let's calculate the square root
            return (int)Math.Sqrt((double)number);
        }

        public int PerformMath(string input)
        {
            // Convert the string to an integer if possible
            if (int.TryParse(input, out int number))
            {
                // Perform a different math operation on the integer
                // For this example, let's add 10 to the number
                return number + 10;
            }
            else
            {
                // Return -1 if conversion fails
                return -1;
            }
        }
    }
}
