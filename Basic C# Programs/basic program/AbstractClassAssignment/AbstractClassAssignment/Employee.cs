using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable
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

        public static bool operator== (Employee Id, Employee Id1)
        {
            if (Id.Id == Id1.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator!= (Employee Id, Employee Id2)
        {
            if (Id.Id != Id2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
