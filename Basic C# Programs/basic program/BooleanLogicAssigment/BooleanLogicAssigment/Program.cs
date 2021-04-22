using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
           int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Answer \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool qualified = (age > 15 && dui == false && tickets <= 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();

            System.Environment.Exit(1);
        }
    }
}
