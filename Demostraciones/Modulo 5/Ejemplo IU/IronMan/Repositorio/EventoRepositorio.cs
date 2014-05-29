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
    public class EventoRepositorio : Repositorio<Evento>
    {
        public EventoRepositorio(DbContext _ctx)
            : base(_ctx)
        {
        }

        //Recuperar lista de entidades por distinto criterios de campos
        public IQueryable<Evento> GetTodosByLugar(String _lugar)
        {   
            var _eventos = from e in _ctx.Set<Evento>()
                           where e.Lugar == _lugar
                           select e;
            return _eventos; 
        }
        //
        public IQueryable<Evento> GetTodosByNombre(String _nombre)
        {
           var _eventos = from e in _ctx.Set<Evento>()
                          where e.Nombre == _nombre
                          select e;
           return _eventos;
        }
        //
        public IQueryable<Evento> GetTodosByFecha(DateTime _fInicial, DateTime _ffinal)
        {
            var _eventos = from e in _ctx.Set<Evento>()
                          where (e.Fecha >= _ffinal || e.Fecha <= _fInicial)
                          select e;
            return _eventos;
        }
    }
}
