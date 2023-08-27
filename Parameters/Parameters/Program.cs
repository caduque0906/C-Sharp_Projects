using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string"
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.Things.Add("Apple");
            stringEmployee.Things.Add("Banana");
            stringEmployee.Things.Add("Cherry");

            // Instantiate an Employee object with type "int"
            Employee<int> intEmployee = new Employee<int>();
            intEmployee.Things.Add(1);
            intEmployee.Things.Add(2);
            intEmployee.Things.Add(3);

            // Loop through and print all Things for stringEmployee
            Console.WriteLine("Things in stringEmployee:");
            foreach (string thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            // Loop through and print all Things for intEmployee
            Console.WriteLine("\nThings in intEmployee:");
            foreach (int thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
