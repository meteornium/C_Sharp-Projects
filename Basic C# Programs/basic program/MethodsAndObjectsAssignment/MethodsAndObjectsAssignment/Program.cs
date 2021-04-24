using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee
            {
                FirstName = "Sample", // setting object firstname
                LastName = "Student" // setting object lastname
            }; // instantiating new employee object

            test.SayName(); // calling method on object
            Console.ReadLine();
        }
    }
}
