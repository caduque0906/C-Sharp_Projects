using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Alice", LastName = "Williams" },
                new Employee { Id = 5, FirstName = "Michael", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Joe", LastName = "Jones" },
                new Employee { Id = 7, FirstName = "David", LastName = "Davis" },
                new Employee { Id = 8, FirstName = "Sarah", LastName = "Miller" },
                new Employee { Id = 9, FirstName = "Emily", LastName = "Wilson" },
                new Employee { Id = 10, FirstName = "Robert", LastName = "Moore" }
            };

            // Using a foreach loop to filter employees with the first name "Joe"
            List<Employee> joesUsingForeach = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesUsingForeach.Add(employee);
                }
            }

            // Using a lambda expression to filter employees with the first name "Joe"
            List<Employee> joesUsingLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Using a lambda expression to filter employees with Id greater than 5
            List<Employee> idGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Display the results
            Console.WriteLine("Employees with first name 'Joe' using foreach:");
            foreach (Employee joe in joesUsingForeach)
            {
                Console.WriteLine($"ID: {joe.Id}, First Name: {joe.FirstName}, Last Name: {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with first name 'Joe' using lambda:");
            foreach (Employee joe in joesUsingLambda)
            {
                Console.WriteLine($"ID: {joe.Id}, First Name: {joe.FirstName}, Last Name: {joe.LastName}");
            }

            Console.WriteLine("\nEmployees with ID greater than 5 using lambda:");
            foreach (Employee employee in idGreaterThan5)
            {
                Console.WriteLine($"ID: {employee.Id}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }

            Console.ReadLine();
        }
    }
    }
}
