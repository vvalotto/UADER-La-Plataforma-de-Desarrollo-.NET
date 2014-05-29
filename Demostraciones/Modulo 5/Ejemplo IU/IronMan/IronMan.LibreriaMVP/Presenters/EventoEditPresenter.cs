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
        private EventoGestor _eGestor;
        private readonly IEventoEditView _view;

        private EventoDTO _eDTONuevo = new EventoDTO();
        private EventoDTO _eDTOAnterior = new EventoDTO();
        private int _eId;

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

        public override void Inicializar()
        {
            this._view.Guardar += OnClickGuardar;
            this._view.Cancelar += OnClickCancelar;
            this._view.Volver += OnClickVolver;

            if (this.eId > 0)
            {
                this.EventoAnterior = this._eGestor.Obtener(this.eId);
                this._view.MostrarEvento(this.eId);
            }
        }

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

        #region Eventos
        public void OnClickGuardar()
        {
            _eGestor.Guardar(this._eDTONuevo);
        }

        public void OnClickCancelar()
        {
            this._view.MostrarEvento(this.eId);
        }

        public void OnClickVolver()
        {
            //No implementado
        }
        #endregion
    }
}
