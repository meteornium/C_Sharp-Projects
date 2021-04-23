using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class VoidClass
    {
        public void VoidMethod(int first, int second)
        {
            // math done on the first parameter
            int firstMessedWith = first * 900 / 64 + 94 - 333 + 853 * 7 / 90 % 8;

            // simple writeline for second parameter
            Console.WriteLine(second);
        }
    }
}
