using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Operation
    {
        public int Addition(int operate)
        {
            Random random = new Random();
            int result = random.Next(1, 1000) + operate;
            return result;
        }

        public int Addition(decimal operate)
        {
            Random random = new Random();
            int operate2 = Convert.ToInt32(operate);
            int result = random.Next(500, 1500) + operate2;
            return result;
        }
        public int Addition(string operate)
        {
            Random random = new Random();
            int operate2 = Convert.ToInt32(operate);
            int result = random.Next(1000, 2000) + operate2;
            return result;
        }
    }
}
