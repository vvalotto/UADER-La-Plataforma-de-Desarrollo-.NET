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
        /* Presenter que maneja los eventos del a vista de Edicion de eventos y 
        junto con el Gestor de Eventos (Modelo).
        Con esta vista se puede crear un nuevo evento o modificar uno existente */

        /*El presenter contiene la asociacion con el modelo y con la vista*/
        private readonly IEventosListView _view;
        private readonly EventoGestor _eGestor;

        #region Constructor
        public EventoListPresenter(IEventosListView _view, EventoGestor _eGestor):
            base(_view)
        {
            this._view = _view;
            this._eGestor = _eGestor;

        }
        #endregion

        #region Inicializa la estructura de la vista
        public override void  Inicializar()
        {
            var _eventos = this._eGestor.Listar();

            /* Para cada una de la acciones previstas de la vista
            * se le asigna el tratamiento de los evento del presenter
            */
            this._view.SeleccionarEvento += OnEventoSeleccionado;

            /*Cuando se inicializa el presenter el dice a al vista que
             * tiene que mostrar la lista de eventos, y si se debe mostrar un evento
             * que sea el primero*/
            this._view.ListarEventos(_eventos);
            if (_eventos != null && _eventos.Count != 0)
            {
                this._view.MostrarEvento(_eventos.First());
            }
        }
        #endregion

        #region Tratamiento de la acciones disparadas desde la vista
        public void OnEventoSeleccionado()
        {
            var id = this._view.EventoSeleccionado;
            if (id != 0)
            {
                var evento = this._eGestor.Obtener(id);
                this._view.MostrarEvento(evento);
            }
        }
        #endregion
    }
}
