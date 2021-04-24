using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisor instance = new Divisor(); // instantiating class

            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            instance.Division(userNum); // original method called
            Console.WriteLine("This is the number you inputted after not using output parameters: " + userNum);
            Console.ReadLine();

            instance.Division(out userNum); // calling overloaded method using output parameter
            Console.WriteLine("This is the number you inputted after using output parameters: " + userNum);
            Console.ReadLine();

            // static below

            Console.WriteLine("This is a method using a static class.");
            Console.WriteLine("Please enter a number.");
            int userNumTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Static.MethodNew(userNumTwo)); 
            Console.ReadLine();
        }
    }
}
