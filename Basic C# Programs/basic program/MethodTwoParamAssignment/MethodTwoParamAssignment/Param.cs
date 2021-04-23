using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTwoParamAssignment
{
    public class Param
    {
        public int MultiplyByTwo(int inputNum, int times = 1)
        {
            int result = 2 * inputNum * times;
            return result;
        }
    }
}
