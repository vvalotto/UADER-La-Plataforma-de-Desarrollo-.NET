using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.Dominio.Modelos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace IronMan.Repositorio
{
    public class PruebaRepositorio : Repositorio<Prueba>
    {
        //
       public PruebaRepositorio(DbContext _ctx)
            : base(_ctx)
        {
        }
        //
       public IQueryable<Prueba> GetTodosByEvento(int _idEvento)
       {
           var _prueba = from e in _ctx.Set<Prueba>()
                         where e.Evento_Id == _idEvento
                         select e;
           return _prueba;
       }
        //
        public IQueryable<Prueba> GetTodosByTipo(String _tipo)
        {   
            var _prueba = from e in _ctx.Set<Prueba>()
                           where e.Tipo == _tipo
                           select e;
            return _prueba; 
        }
        //
        public IQueryable<Prueba> GetTodosByNombre(String _distancia)
        {
            var _prueba = from e in _ctx.Set<Prueba>()
                          where e.Distancia == _distancia
                          select e;
            return _prueba; 
 
        }

    }
}
