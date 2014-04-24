using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFLinq
{
    internal class ManejadorProyectos
    {
       
        internal Proyectos ObtenerProyecto(ProyectosDataContext _ctx, int _id)
        {
            var _proyectos = from p in _ctx.Proyectos
                             where p.ID == _id
                             select p;

            Proyectos _unProyecto = _proyectos.SingleOrDefault();
            return _unProyecto;
        }

        internal void GuardarProyecto(ProyectosDataContext _ctx, Proyectos _proyecto)
        {
            _ctx.Proyectos.InsertOnSubmit(_proyecto);
            _ctx.SubmitChanges();

        }

        internal void ActualizarProyecto (ProyectosDataContext _ctx, Proyectos _proy)
        {
            var _proyectos = from p in _ctx.Proyectos
                             where p.ID == _proy.ID
                             select p;
            Proyectos _unProyecto = _proyectos.SingleOrDefault();

            if (_unProyecto != null)
            {
                _unProyecto.Titulo = _proy.Titulo;
                _unProyecto.IDCliente = _proy.IDCliente;
                _ctx.SubmitChanges();
            }

        }

        internal void EliminarProyecto (ProyectosDataContext _ctx, int _id)
        {
            var _proyectos = from p in _ctx.Proyectos
                             where p.ID == _id
                             select p;
            Proyectos _unProyecto = _proyectos.SingleOrDefault();

            if (_unProyecto != null)
            {
                _ctx.Proyectos.DeleteOnSubmit(_unProyecto);
                _ctx.SubmitChanges();
            }
        }

        internal List<Proyectos> ObtenerLista(ProyectosDataContext _ctx)
        {
            return (from p in _ctx.Proyectos
                    select p).ToList();
        }

    }
}
