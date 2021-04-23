using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 1
            string[] stringArray = { "Hello", "my", "name", "is", "Adam" };

            Console.WriteLine("Please enter what you would like added to the end of each item within a string array.");
            string input = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += input;
            }

            foreach (string strings in stringArray)
            {
                Console.WriteLine(strings);
            }

            Console.ReadLine();

            // part 2
            // infinite loop that was then fixed. set condition that while our boolean is false (which never changed in the first scenario), it prints this line over and over. changed it so that once it does the passing statement, it changes the boolean to true, stopping the lop
            bool whileLoop = false;

            while (whileLoop == false)
            {
                Console.WriteLine("Hey, this is false!");
                whileLoop = true;
            }

            Console.WriteLine("Next we will loop using < comparison.");
            Console.ReadLine();

            // part 3
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(stringArray[j]);
            }

            Console.WriteLine("Next we will loop using <= comparison.");
            Console.ReadLine();

            for (int n = 0; n <= 3; n++)
            {
                Console.WriteLine(stringArray[n]);
            }

            Console.ReadLine();

            // part 4
            List<string> names = new List<string>() { "Adam", "Casey", "Michael", "Danny", "Kyle" };

            Console.WriteLine("Input text and I will tell you where it is on the list!");
            string wordInput = Console.ReadLine();
            int nameIndex = -1;

            for (int i = 0; i < names.Count; i++)
            {
                if (wordInput == names[i])
                {
                    nameIndex = i;
                    break;
                }
            }

            if (nameIndex != -1) // checks if nameIndex is no longer -1, which means it has changed
            {
                Console.WriteLine("What you inputted is at " + nameIndex + " index.");
            }
            else
            {
                Console.WriteLine("What you inputted was not in the list, sorry!");
            }

            Console.ReadLine();

            // part 5
            List<string> names1 = new List<string>() { "Adam", "Casey", "Adam", "Danny", "Kyle" };
            List<int> indexes = new List<int>();

            Console.WriteLine("Input text and I will search to see where it is in the list.");
            string wordInput1 = Console.ReadLine();

            for (int i = 0; i < names1.Count; i++)
            {
                if (names1[i] == wordInput1)
                {
                    indexes.Add(i); // adds the value of the indexes that mathc the user input into indexes List
                }
            }

            string indexOutput = "" ;

            for (int j = 0; j < indexes.Count; j++)
            {
                indexOutput += indexes[j] + " "; // space to space the indices out
            }

            if (indexOutput != "") // checks if indexOutput is not empty. if its not, there are things to print!
            {
                Console.WriteLine("What you inputted is at index: " + indexOutput);
            }
            else
            {
                Console.WriteLine("What you inputted was not in the list, sorry!");
            }

            Console.ReadLine();

            // part 6
            List<string> names2 = new List<string>() { "Adam", "Casey", "Adam", "Danny", "Kyle" };
            List<string> foundNames = new List<string>();

            foreach (string name in names2)
            {
                if (foundNames.Contains(name)) // checks if the list foundNames contains the name that is being checked. if not, go to else
                {
                    Console.WriteLine(name + ". This has appeared already.");
                }
                else
                {
                    foundNames.Add(name); // puts name in foundNames to be checked on for later
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();
        }
    }
}
