using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() // method for the person class that prints objects name
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); 
        }
    }
}
