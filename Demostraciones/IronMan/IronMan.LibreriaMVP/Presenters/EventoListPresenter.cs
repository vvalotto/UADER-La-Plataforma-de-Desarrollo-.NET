using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.LibreriaMVP.Views;
using IronMan.Gestores;

namespace IronMan.LibreriaMVP.Presenters
{
    public class EventoListPresenter: BasePresenter<IEventosListView>
    {
        private readonly IEventosListView _view;
        private readonly EventoGestor _eGestor;

        public EventoListPresenter(IEventosListView _view, EventoGestor _eGestor):
            base(_view)
        {
            this._view = _view;
            this._eGestor = _eGestor;

        }

        public override void  Inicializar()
        {
            var _eventos = this._eGestor.Listar();

            this._view.SeleccionarEvento += OnEventoSeleccionado;
            this._view.ListarEventos(_eventos);

            if (_eventos != null && _eventos.Count != 0)
            {
                this._view.MostrarEvento(_eventos.First());
            }
        }

        public void OnEventoSeleccionado()
        {
            var id = this._view.EventoSeleccionado;
            if (id != 0)
            {
                var evento = this._eGestor.Obtener(id);
                this._view.MostrarEvento(evento);
            }
        }
    }
}
