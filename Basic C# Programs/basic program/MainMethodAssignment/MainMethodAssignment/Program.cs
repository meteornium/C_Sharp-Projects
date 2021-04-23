using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating our class
            Operation instance = new Operation();

            Console.WriteLine("Give a number.");
            int userNumberOne = Convert.ToInt32(Console.ReadLine()); 
            
            int resultOne = instance.Addition(userNumberOne); // calling the first method
            Console.WriteLine("Your result is: " + resultOne);
            Console.ReadLine();

            Console.WriteLine("Give a decimal.");
            decimal userNumberTwo = Convert.ToDecimal(Console.ReadLine()); // saves input as a decimal for method to use

            int resultTwo = instance.Addition(userNumberTwo); // calling the second method
            Console.WriteLine("Your result is: " + resultTwo);
            Console.ReadLine();

            Console.WriteLine("Give a number.");
            string userNumberThree = Console.ReadLine(); // saves input as string for method to use

            int resultThree = instance.Addition(userNumberThree); // calling the third method
            Console.WriteLine("Your result is: " + resultThree);
            Console.ReadLine();
        }
    }
}
