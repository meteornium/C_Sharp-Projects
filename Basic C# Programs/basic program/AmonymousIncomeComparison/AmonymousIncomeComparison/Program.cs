using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program" + "\n" + "\n" + "Person 1" + "\n" + "Hourly Rate?");
            int oneHourly = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int oneHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "Person 2" + "\n" + "Hourly Rate?");
            int twoHourly = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int twoHours = Convert.ToInt32(Console.ReadLine());

            int oneSalary = oneHourly * oneHours * 52;
            int twoSalary = twoHourly * twoHours * 52;

            bool comparison = oneSalary > twoSalary;

            Console.WriteLine("\n" + "Annual salary of Person 1:" + "\n" + oneSalary + "\n" + "\n" + "Annual salary of Person 2:" + "\n" + twoSalary);
            Console.WriteLine("\n" + "Does Person 1 make more money than Person 2?" + "\n" + comparison);
            Console.ReadLine();

        }
    }
}
