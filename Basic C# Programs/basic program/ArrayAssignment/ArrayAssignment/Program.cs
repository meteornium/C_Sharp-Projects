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
            string[] stringArray = { "Hello", "How are you?", "What is your favorite book?", "Have a nice day!" };
            string notInArray = "That index is not in the array. Try again with a smaller number.";

            Console.WriteLine("Select an index.");
            int index = Convert.ToInt32(Console.ReadLine());
            
            if ( 0 <= index && index < stringArray.Length )
            {
                Console.WriteLine(stringArray[index]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(notInArray);
                Console.WriteLine("Select an index.");
                index = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
