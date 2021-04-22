using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below." + "\n" + "Enter package weight as a number:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Pacakge express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(1);
            }

            Console.WriteLine("Enter package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            decimal quote = ((width * height * length) * weight) / 100m;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\n" + "Thank you!" + "\n" + "Press any key to exit");
            Console.ReadLine();

            System.Environment.Exit(1);
        }
    }
}
