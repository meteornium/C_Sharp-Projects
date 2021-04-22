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

            // asks if need help, makes boolean variable
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // asks about positive experiences, saves as a string variable
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            // asks if youd like to leave feedback, saves response as a string variable
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedPro = Console.ReadLine();

            // asks how many hours studied, saves as an integer
            Console.WriteLine("How many hours did you study today? Please use only the number.");
            int hoursNum = Convert.ToInt32(Console.ReadLine());

            // prints final line
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            // exits
            System.Environment.Exit(1);
        }
    }
}
