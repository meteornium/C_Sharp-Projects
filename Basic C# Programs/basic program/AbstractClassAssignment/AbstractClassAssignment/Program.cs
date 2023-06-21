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
            Employee<string> strings = new Employee<string>();
            strings.Add("mary");
            Employee<int> employee = new Employee<int>();



            //Employee test = new Employee
            //{
            //    FirstName = "Sample", // setting object firstname
            //    LastName = "Student", // setting object lastname
            //    Id = 12345678 // setting id
            //}; // instantiating new employee object

            //test.SayName(); // calling method on object
            //Console.ReadLine();

            //// instantiatiating interface and calling method on the object
            //IQuittable quittableEmployee = new Employee();
            //quittableEmployee.Quit();

            //// using overloaded equal sign on employee objects
            //Employee test2 = new Employee
            //{
            //    FirstName = "Samm",
            //    LastName = "Spark",
            //    Id = 12345679
            //};

            //Console.WriteLine(test == test2); 
            //Console.ReadLine();

            //// lambda assignment start

            //// making list of 10 employees
            //List<Employee> tenEmployees = new List<Employee>()
            //{
            //    new Employee
            //    {
            //        FirstName = "Joe",
            //        LastName = "Smith",
            //        Id = 1
            //    },
            //    new Employee
            //    {
            //        FirstName = "Adam",
            //        LastName = "Kelley",
            //        Id = 2
            //    },
            //    new Employee
            //    {
            //        FirstName = "Casey",
            //        LastName = "Drinovac",
            //        Id = 3
            //    },
            //    new Employee
            //    {
            //        FirstName = "Michael",
            //        LastName = "Lautner",
            //        Id = 4
            //    },
            //    new Employee
            //    {
            //        FirstName = "Daniel",
            //        LastName = "Tarrantola",
            //        Id = 5
            //    },
            //    new Employee
            //    {
            //        FirstName = "Joe",
            //        LastName = "Abercrombie",
            //        Id = 6
            //    },
            //    new Employee
            //    {
            //        FirstName = "Anastasia",
            //        LastName = "Janil",
            //        Id = 7
            //    },
            //    new Employee
            //    {
            //        FirstName = "Terrace",
            //        LastName = "Johnson",
            //        Id = 8
            //    },
            //    new Employee
            //    {
            //        FirstName = "Rei",
            //        LastName = "Arataka",
            //        Id = 9
            //    },
            //    new Employee
            //    {
            //        FirstName = "Ed",
            //        LastName = "Elric",
            //        Id = 10
            //    }
            //};

            //foreach (Employee employee in tenEmployees) // looks throught the employees in the list
            //{
            //    if (employee.FirstName == "Joe") // checks if the first name prop is equal to joe
            //    {
            //        List<Employee> JoeList = new List<Employee>(); // making a new list
            //        JoeList.Add(employee); // adding those employees to this list
            //    }
            //}

            //// lambda func simplification. made a new list called listofjoes, called the original list,
            //// used the Where method to find where the first name prop equals Joe,
            //// converted that info to a list and since that is being set equal to the new ListofJoes list
            //// then all those employees that pass are immediately put in the new list
            //// named variable in the function 'employee' to help me makes sense of what is being passed through
            //List<Employee> ListofJoes = tenEmployees.Where(employee => employee.FirstName == "Joe").ToList();

            //// lambda function checking if id is greater than five and then adding them to new list
            //List<Employee> LessThanFive = tenEmployees.Where(employee => employee.Id < 5).ToList();
        }
    }
}
