using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTwoParamAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplyResult = 0;
            Param instance = new Param();

            Console.WriteLine("You will have two prompts to input numbers. For the second prompt, you do not have to enter a number. \n \nPlease enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine()); // converts the first number to an int to be used in method

            Console.WriteLine("Please enter a second number. You do not have to if you do not want to.");
            string userInput = Console.ReadLine(); // makes user input a string in order for us to check it in if statement

            if (userInput != "") // checks user input. if the string is NOT empty, that means user inputted something and therefore need to use it
            {
                int userTimes = Convert.ToInt32(userInput);
                multiplyResult = instance.MultiplyByTwo(userNum, userTimes);
                Console.WriteLine(userNum + " times two " + userTimes + " time(s) is: " + multiplyResult);
            } 
            else // case that user did not input anything. using default values set in the method
            {
                multiplyResult = instance.MultiplyByTwo(userNum);
                Console.WriteLine(userNum + " times two one time is: " + multiplyResult);
            }

            Console.ReadLine();
        }
    }
}
