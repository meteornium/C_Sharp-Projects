using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee test = new Employee
            {
                FirstName = "Sample", // setting object firstname
                LastName = "Student", // setting object lastname
                Id = 12345678 // setting id
            }; // instantiating new employee object

            test.SayName(); // calling method on object
            Console.ReadLine();

            // instantiatiating interface and calling method on the object
            IQuittable quittableEmployee = new Employee();
            quittableEmployee.Quit();

            // using overloaded equal sign on employee objects
            Employee test2 = new Employee
            {
                FirstName = "Samm",
                LastName = "Spark",
                Id = 12345679
            };

            Console.WriteLine(test == test2); 
            Console.ReadLine();
        }
    }
}
