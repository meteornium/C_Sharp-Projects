using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Employee : Person // this colon person allows employee to inherit the person class' behavior and properties
    {
        public int Id { get; set; }
    }
}
