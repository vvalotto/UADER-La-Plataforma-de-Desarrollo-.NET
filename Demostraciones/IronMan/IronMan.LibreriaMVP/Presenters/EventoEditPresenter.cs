using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.LibreriaMVP.Views;
using IronMan.Gestores;
using IronMan.DTO;

namespace IronMan.LibreriaMVP.Presenters
{
    public class EventoEditPresenter : BasePresenter<IEventoEditView>
    {
        /* Presenter que maneja los eventos del a vista de Edicion de eventos y 
         junto con el Gestor de Eventos (Modelo).
         Con esta vista se puede crear un nuevo evento o modificar uno existente */

        /*El presenter contiene la asociacion con el modelo y con la vista*/
        private EventoGestor _eGestor;
        private readonly IEventoEditView _view;

        private EventoDTO _eDTONuevo = new EventoDTO();
        private EventoDTO _eDTOAnterior = new EventoDTO();
        private int _eId;

        #region Constructor
        public EventoEditPresenter(IEventoEditView _view, EventoGestor _eGestor):
            base(_view)
        {
            this._view = _view;
            this._eGestor = _eGestor;
            if (this.eId > 0)
            {
                EventoDTO _eDTO = _eGestor.Obtener(this.eId);
                this.EventoAnterior = _eDTO;
            }
        }
        #endregion

        #region Inicializa la estructura de la vista
        public override void Inicializar()
        {
            /* Para cada una de la acciones previstas de la vista
             * se le asigna el tratamiento de los evento del presenter
             */
            this._view.Guardar += OnClickGuardar;
            this._view.Cancelar += OnClickCancelar;
            this._view.Volver += OnClickVolver;

            /*Cuando se inicializa la vista, se examina el hay un Id
             * valida de manera de ir a rescatarlo desde la persistencia a traves 
             * del gestor y pasarle los datos de la entidad a mostrar a la vista*/
            if (this.eId > 0)
            {
                this.EventoAnterior = this._eGestor.Obtener(this.eId);
                this._view.MostrarEvento(this.eId);
            }
        }
        #endregion

        #region Priopiedades Publicas
        public EventoDTO EventoNuevo
        {
            get
            {
                return _eDTONuevo;
            }
            set
            {
                _eDTONuevo = value;
            }
        }

        public EventoDTO EventoAnterior
        {
            get
            {
                return _eDTOAnterior;
            }
            set
            {
                _eDTOAnterior = value;
            }
        }

        public int eId
        {
            get { return _eId; }
            set { _eId = value; }
        }
        #endregion

        #region Tratamiento de la acciones disparadas desde la vista
        public void OnClickGuardar()
        {
            /*Desde la vista se ejecuta la accion guardar y el presenter
             * llama al gestor para persistir el cambio en la entidad*/
            _eGestor.Guardar(this._eDTONuevo);
        }

        public void OnClickCancelar()
        {
            /*Desde la vista se cancela la accion y el presenter llama a la vista
             * para mostrar el entidad previa al cambio*/
            this._view.MostrarEvento(this.eId);
        }

        public void OnClickVolver()
        {

        }
        #endregion
    }
}
