using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;
using IronMan.Gestores;
using MVCWinForm.Vista;

namespace MVCWinForm.Modelo
{
    public class ListaEventoObservado: EventoGestor, IModeloObservado
    {

        private List<IVistaObservador> observadores = new List<IVistaObservador>();
        private string _tipoActualizacion;

        public string TipoActualizacion
        {
            get { return _tipoActualizacion; }
            set { _tipoActualizacion = value; }
        }

        public void AgregarObservador(IVistaObservador observador)
        {
            observadores.Add(observador);
        }

        public void RetirarObservador(IVistaObservador observador)
        {
            observadores.Remove(observador);
        }

        public void Notificar()
        {
            observadores.ForEach(x => x.Actualizar(_tipoActualizacion));
        }

        public void AgregarEvento(EventoDTO evento)
        {
            try
            {
                Guardar(evento);
                TipoActualizacion = "Se agrego el evento";
                
            }
            catch
            {
                TipoActualizacion = "Error al agregar el evento";
            }
            Notificar();
        }

        public IList<EventoDTO> ListarEventos()
        {
            IList<EventoDTO> eventos = null; 
            try
            {
                eventos = Listar();
                TipoActualizacion = "Se listaron los eventos";
            }
            catch
            {
                TipoActualizacion = "Error al agregar el evento";
            }
            Notificar();
            return eventos;

        }
    }
}
