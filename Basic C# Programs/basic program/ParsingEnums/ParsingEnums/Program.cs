using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                string userInput = Console.ReadLine();
                DaysOfTheWeek daysOf = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);
                Console.WriteLine("You entered: " + daysOf);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
            
            
        }
    }
}
