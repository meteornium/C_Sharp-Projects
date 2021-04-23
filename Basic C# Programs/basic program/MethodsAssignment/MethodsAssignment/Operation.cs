using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Operation
    {
        //multipy, subtract, add methods. take user input and use math.random
        public static int Add(int operation)
        { // adds the number by a random num
            Random random = new Random(); // this instatiates random
            int result = operation + random.Next(1, 1000); // limiting the random num between 1 and 1000
            return result; // returns the result
        }

        public static int Multiply(int operation)
        { // multiplies by a random num
            Random random = new Random();
            int result = operation * random.Next(1, 1000);
            return result;
        }

        public static int Subtract(int operation)
        {
            Random random = new Random();
            int result = operation - random.Next(1, 1000);
            return result;
        }
    }
}
