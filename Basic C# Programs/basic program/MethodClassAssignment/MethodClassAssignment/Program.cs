using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidClass instance = new VoidClass();

            // calling object and applying method to it
            instance.VoidMethod(21, 32);            

            // using parameter names when calling method on object
            instance.VoidMethod(first: 33, second: 50);
            Console.ReadLine();
        }
    }
}
