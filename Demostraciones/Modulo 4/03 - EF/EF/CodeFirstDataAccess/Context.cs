using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CodeFirstModelo;


namespace CodeFirstDataAccess
{
    public class Context : DbContext
    {
        public Context()
            : base(SchoolConnectionString)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
