using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student1 = new Student() { StudentName = "Adam" };

                ctx.Students.Add(student1);
                ctx.SaveChanges();
            }
        }
    }
}
