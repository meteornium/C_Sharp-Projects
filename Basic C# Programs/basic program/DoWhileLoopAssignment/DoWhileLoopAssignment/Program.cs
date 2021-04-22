using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create variable color thatn takes user input for comparison against future cases in switch statement. creates a boolean in order for us to perform loop
            Console.WriteLine("Guess my favorite color!");
            string color = Console.ReadLine();
            bool isGuessed = color == "green";

            // beginning of do while loop. switch statement inside
            do
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("Blue is NOT my favorite color!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("Red is NOT my favorite color!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    case "black":
                        Console.WriteLine("Black is NOT my favorite color!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("Green IS my favorite color! You win!");
                        isGuessed = true; // setting isGuessed to true in order to exit the loop
                        break;
                    default:
                        Console.WriteLine("That is NOT my favorite color!");
                        Console.WriteLine("Guess my favorite color!");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed); // states that while isGuessed is false, do this loop

            //while (!isGuessed) // while isGuessed is false, this will happen
            //{
            //    switch (color)
            //    {
            //        case "blue":
            //            Console.WriteLine("Blue is NOT my favorite color!");
            //            Console.WriteLine("Guess my favorite color!");
            //            color = Console.ReadLine();
            //            break;
            //        case "red":
            //            Console.WriteLine("Red is NOT my favorite color!");
            //            Console.WriteLine("Guess my favorite color!");
            //            color = Console.ReadLine();
            //            break;
            //        case "black":
            //            Console.WriteLine("Black is NOT my favorite color!");
            //            Console.WriteLine("Guess my favorite color!");
            //            color = Console.ReadLine();
            //            break;
            //        case "green":
            //            Console.WriteLine("Green IS my favorite color! You win!");
            //            isGuessed = true; // lets us exit our loop
            //            break;
            //        default:
            //            Console.WriteLine("That is NOT my favorite color!");
            //            Console.WriteLine("Guess my favorite color!");
            //            color = Console.ReadLine();
            //            break;
            //    }
            //}

            Console.Read();
        }
    }
}
