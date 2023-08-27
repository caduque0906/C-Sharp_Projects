using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two employee objects
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare employee objects using overloaded operators
            bool areEqual = employee1 == employee2;
            bool areNotEqual = employee1 != employee2;

            // Display comparison results
            Console.WriteLine($"Employee objects are equal: {areEqual}");
            Console.WriteLine($"Employee objects are not equal: {areNotEqual}");

            Console.ReadLine();

        }
    }
}
