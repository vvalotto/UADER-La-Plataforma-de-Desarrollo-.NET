using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Linq;


namespace ModeloFirst
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected  DbSet<T> DbSet;
        private DbContext _ctx;

        public Repositorio(DbContext ctx)
        {
            _ctx = ctx;
            DbSet = ctx.Set<T>();
        }


        public void Guardar(T entidad)
        {
 	        DbSet.Add(entidad);
        }

        public void Actualizar(T entidad)
        {
            DbSet.Attach(entidad);
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
