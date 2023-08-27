using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the equality operator "=="
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null or reference the same object
            if (ReferenceEquals(employee1, employee2))
                return true;

            // If either object is null, return false
            if ((object)employee1 == null || (object)employee2 == null)
                return false;

            // Compare the Id properties for equality
            return employee1.Id == employee2.Id;
        }

        // Overloading the inequality operator "!="
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
