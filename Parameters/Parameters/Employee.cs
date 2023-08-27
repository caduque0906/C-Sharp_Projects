using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    // Employee class now takes a generic type parameter
    class Employee<T>
    {
        public List<T> Things { get; set; } // Property to hold a generic list of things

        // Constructor to initialize the Things property
        public Employee()
        {
            Things = new List<T>();
        }
    }
}
