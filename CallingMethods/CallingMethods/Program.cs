using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class MathOperations
    {
        public int Square(int number)
        {
            return number * number;
        }

        public int Double(int number)
        {
            return number * 2;
        }

        public int Increment(int number)
        {
            return number + 1;
        }
    }

    Console.ReadLine();
}
