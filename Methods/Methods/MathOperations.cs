using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class MathOperations
    {
        public int PerformMath(int num1, int num2 = 0)
        {
            // Do a math operation (addition in this case)
            int result = num1 + num2;
            return result;
        }
    }
}
