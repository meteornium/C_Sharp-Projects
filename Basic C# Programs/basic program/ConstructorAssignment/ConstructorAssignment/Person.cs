using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Person
    {
        // connecting the larger constructor to this on, setting income at 50000 if nothing is inputted
        public Person(string name) : this(name, 50000)
        {
        }
        // base person contructor. takes in a name and income input
        public Person(string name, int income)
        {
            Name = name;
            Income = income;
        }

        public string Name { get; set; } 
        public int Income { get; set; }
    }
}
