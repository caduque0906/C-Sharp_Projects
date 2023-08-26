using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Carlos",
                LastName = "Duque",
                Id = 123
            };

            // Call the SayName() method on the Employee object
            employee.SayName();

            Console.Read();
        }
    }
}
