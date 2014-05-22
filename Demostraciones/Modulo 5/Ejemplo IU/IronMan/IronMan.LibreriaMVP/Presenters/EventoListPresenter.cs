using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.LibreriaMVP.Views;
using IronMan.Gestores;

namespace IronMan.LibreriaMVP.Presenters
{
    public class EventoListPresenter
    {
        private readonly IEventosListView _view;
        private readonly EventoGestor _eGestor;

        public EventoListPresenter(IEventosListView _view, EventoGestor _eGestor)
        {
            this._view = _view;
            this._eGestor = _eGestor;

            var _eventos = this._eGestor.Listar();

            this._view.SeleccionarEvento += OnEventoSeleccionado;
            this._view.ListarEventos(_eventos);

            if (_eventos != null)
            {
                this._view.MostrarEvento(_eventos.First());
            }
        }

        public void OnEventoSeleccionado()
        {
            if (this._view.EventoSeleccionado != 0)
            {
                var id = this._view.EventoSeleccionado;
                var evento = this._eGestor.Obtener(id);

                this._view.MostrarEvento(evento);
            }
        }
    }
}
