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
            Operation instance = new Operation();

            Console.WriteLine("Give a number.");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            
            int resultOne = instance.Addition(userNumberOne);
            Console.WriteLine("Your result is: " + resultOne);
            Console.ReadLine();

            Console.WriteLine("Give a decimal.");
            decimal userNumberTwo = Convert.ToDecimal(Console.ReadLine());

            int resultTwo = instance.Addition(userNumberTwo);
            Console.WriteLine("Your result is: " + resultTwo);
            Console.ReadLine();

            Console.WriteLine("Give a number.");
            string userNumberThree = Console.ReadLine();

            int resultThree = instance.Addition(userNumberThree);
            Console.WriteLine("Your result is: " + resultThree);
            Console.ReadLine();
        }
    }
}
