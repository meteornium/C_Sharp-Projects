using System;
using System.Collections.Generic;

namespace ArrayaAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(17);
            intList.Remove(17);

            Console.WriteLine(intList[0]);
            Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 10;
            //numArray[2] = 43;
            //numArray[3] = 57;
            //numArray[4] = 4775;

            //int[] numArray1 = new int[] { 5, 2, 10, 2500, 5000 };

            //int[] numArray2 = { 5, 2, 10, 2500, 5000 };

            //numArray2[4] = 650;

            //Console.WriteLine(numArray2[3]);
            //Console.ReadLine();
        }
    }
}
