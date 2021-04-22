using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Submit a number.");
            int multiply = Convert.ToInt32(Console.ReadLine());
            int product = multiply * 50;

            Console.WriteLine("Your number times 50 is..." + product.ToString());

            Console.WriteLine("Submit a number.");
            int add = Convert.ToInt32(Console.ReadLine());
            int result = add + 25;

            Console.WriteLine("Your number plus 25 is..." + result.ToString());

            Console.WriteLine("Submit a number.");
            int divide = Convert.ToInt32(Console.ReadLine());
            double quotient = divide / 12.5;

            Console.WriteLine("Your number divided by 12.5 is..." + quotient.ToString());

            Console.WriteLine("Submit a number.");
            int compare = Convert.ToInt32(Console.ReadLine());
            bool comparison = compare > 50;

            Console.WriteLine("Your number is greater than 50..." + comparison.ToString());

            Console.WriteLine("Submit a number");
            int divider = Convert.ToInt32(Console.ReadLine());
            int modulus = divider % 7;

            Console.WriteLine("The remainder of your number divided by 7 is..." + modulus.ToString());
            Console.ReadLine();

            System.Environment.Exit(1);
        }
    }
}
