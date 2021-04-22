using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndCompaisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 5 - 3;
            //Console.WriteLine("Five minus three = " + difference.ToString());
            //Console.ReadLine();

            //int multiply = 10 * 5;
            //Console.WriteLine("Ten times five = " + multiply.ToString());
            //Console.ReadLine();

            //int dividend = 200 / 3;
            //Console.WriteLine(dividend);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 70;

            //bool isWarm = currentTemp >= roomTemp;
            //bool isWarm = currentTemp == roomTemp;
            bool isWarm = currentTemp != roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
