using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 100, 200, 300, 400, 500 };
            List<int> modifiedList = new List<int>(); // empty list to be used to push numbers in

            try
            {
                Console.WriteLine("Give a number and I will divide everything in my list by that number!");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // loop going through numberList, dividing each element by userNumber and then adding them to the empty modifiedList
                for (int i = 0; i < numberList.Count; i++)
                {
                    modifiedList.Add(numberList[i] / userNumber);
                }

                // this foreach prints each element in modifiedList, showing the results
                foreach (int number in modifiedList)
                {
                    Console.WriteLine(number);
                }
            }
            catch (FormatException) // if you input something other than an int
            {
                Console.WriteLine("Please input a number.");
            }
            catch (DivideByZeroException) // if user inputs 0
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (Exception ex) // all other cases
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
