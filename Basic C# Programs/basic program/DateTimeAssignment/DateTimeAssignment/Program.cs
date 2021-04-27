using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now; // setting the current time to a variable
            Console.WriteLine(rightNow); // this prints the current datetime to the console
            Console.WriteLine("Input a number.");
            int userNum = Convert.ToInt32(Console.ReadLine()); // taking in user input as an int
            DateTime futureTime = rightNow.AddHours(userNum); // setting new variable equal to the current time plus the user inputted num in terms of hours

            Console.WriteLine("In {0} hours, it will be {1}.", userNum, futureTime); // printing the result
            Console.ReadLine();
        }
    }
}
