using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            new NotImplementedException();
        }

        public List<T> Things { get; set; }

        //public static bool operator== (Employee Identification1, Employee Identification2) // overloading == variable, returning a boolean
        //{
        //    return Identification1.Id == Identification2.Id;
        //}

        //public static bool operator!= (Employee Identification1, Employee Identification2) // overloading != variable, done so in order to satisfy overloading == variable
        //{
        //    return Identification1.Id != Identification2.Id;
        //}
    }
}
