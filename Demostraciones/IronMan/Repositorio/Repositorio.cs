using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace IronMan.Repositorio
{

    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected DbSet<T> DbSet;
        protected DbContext _ctx;

        public Repositorio(DbContext ctx)
        {
            _ctx = ctx;
            DbSet = ctx.Set<T>();
        }

        //Guardar una nueva entidad o los cambios sobre la entidad
        public void Guardar(T entidad, int Id)
        {
            //En esta implementacion si el Id es 0 es porque se
            //está creando la entidad, es una entidad nueva,
            //de otra manera se guardar el contexto con los
            //cambios en la entidad
            Console.WriteLine(_ctx.Entry(entidad).State.ToString());
            if (Id == 0)
            {
                DbSet.Add(entidad);
            }
            _ctx.SaveChanges();
        }

        //Obtener la entidad por identificador (Clave Primaria)
        public T GetPorId(int id)
        {
            return DbSet.Find(id);
        }

        //Obtener todos las instancias de dicha entidad
        public IQueryable<T> GetTodos()
        {
            return DbSet;
        }

    }
}
