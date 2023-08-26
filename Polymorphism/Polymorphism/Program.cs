using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Employee"
            };

            // Call the SayName method on Employee
            employee.SayName();

            // Demonstrate polymorphism using IQuittable interface
            IQuittable quittable = employee;
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
