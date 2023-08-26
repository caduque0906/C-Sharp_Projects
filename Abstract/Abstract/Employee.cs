using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee : Person
    {
        public override void SayName()
        {
            // Display the full name of the employee
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
