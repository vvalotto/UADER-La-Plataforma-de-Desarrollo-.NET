using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstModelo;
using CodeFirstDataAccess;

namespace CodeFirstConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando....");

            using (var ctx = new Context())
            {
                Student stud = new Student() { StudentName = "New Student" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
      
        }
    }
}
