using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Divisor
    {
        public void Division(int dividend)
        {
            int result = dividend / 2;
            Console.WriteLine("Your number by 2 is: " + result);
        }

        public void Division(out int x) // overloading method. using out int to differentiate so they dont conflict
        {
            Console.WriteLine("Submit a number.");
            x = Convert.ToInt32(Console.ReadLine()); // have to set x in order for out param to work. got angry when i tried to use it without setting a value first.
            x /= 2;
            Console.WriteLine("Your number by 2 is: " + x);
        }
    }
}
