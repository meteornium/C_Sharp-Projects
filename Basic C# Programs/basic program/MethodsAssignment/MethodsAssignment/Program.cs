using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Submit a number to do math operations on.");
            int userNum = Convert.ToInt32(Console.ReadLine()); // turning user input into an int to be used in the methods

            Console.WriteLine("Added to a random number: " + Operation.Add(userNum)); // calling method

            Console.WriteLine("Multiplied by a random number: " + Operation.Multiply(userNum));

            Console.WriteLine("Subtracted by a random number: " + Operation.Subtract(userNum));

            Console.ReadLine();
        }
    }
}
