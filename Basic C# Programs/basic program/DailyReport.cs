using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints tech academy and student dail report on a seperate line
            Console.WriteLine("The Tech Academy" + "\n" + "Student Daily Report");
            Console.ReadLine();

            // asks name, allows user to input name and saves that as a string variable 
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            // asks course, user inputs course name and saves to a string variable
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            //asks page number, saves that as an integer variable
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there arny other feedback you'd like to provide? Please be specific.");
            string posExp = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hoursNum = Convert.ToInt32(Console.ReadLine());


        }
    }
}