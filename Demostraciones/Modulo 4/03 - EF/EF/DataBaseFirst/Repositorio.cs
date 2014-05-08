using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Linq;


namespace DataBaseFirst
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected  DbSet<T> DbSet;

        public Repositorio(DbContext ctx)
        {
            DbSet = ctx.Set<T>();
        }


        public void Guardar(T entidad)
        {
 	        DbSet.Add(entidad);
        }

        public T GetPorId(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetTodos()
        {
            return DbSet;
        }
    }
}
