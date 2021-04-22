using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing array for strings
            string[] stringArray = { "Hello", "How are you?", "What is your favorite book?", "Have a nice day!" };

            // string that will print when index is submitted that doesnt fit in array length or list count
            string notInArray = "That index is not in the array.";

            Console.WriteLine("This will select a phrase from an array. Select an index.");
            int index = Convert.ToInt32(Console.ReadLine());

            // checks if the index given fits in the array, if it does, does first bit, else it does the...else....            
            if ( 0 <= index && index < stringArray.Length )
            {
                Console.WriteLine(stringArray[index]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(notInArray);
                Console.ReadLine();
            }

            // new array for numbers now
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("This will select a number from an array. Select an index.");
            int index1 = Convert.ToInt32(Console.ReadLine());

            // same if else from before. if the index fits does the first half, else..........it does the else......
            if (0 <= index1 && index1 < numArray.Length)
            {
                Console.WriteLine(numArray[index1]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(notInArray);
                Console.ReadLine();
            }

            // lists of strings! added everything into them using the .Add() method
            List<string> stringList = new List<string>();
            stringList.Add("Hi.");
            stringList.Add("Hey.");
            stringList.Add("Hello.");
            stringList.Add("Hey there.");
            stringList.Add("Greetings.");
            stringList.Add("What's up.");
            stringList.Add("Heyo.");

            Console.WriteLine("This will select a greeting from a list. Select an index.");
            int index2 = Convert.ToInt32(Console.ReadLine());

            // our third branching statement! same as the others, but this time had to use .Count on list because .length is not a property/method you can use on lists (thanks google)
            if (0 <= index2 && index2 < stringList.Count)
            {
                Console.WriteLine(stringList[index2]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(notInArray);
                Console.ReadLine();
            }
        }
    }
}
