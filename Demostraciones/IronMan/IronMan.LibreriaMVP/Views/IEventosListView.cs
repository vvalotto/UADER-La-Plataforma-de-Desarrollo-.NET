using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;

namespace IronMan.LibreriaMVP.Views
{
    public interface IEventosListView : IView
    {
        /*Especificacion de la interfaz de una vista que tiene en cuenta
         * las acciones de listar las entidades, propiedades (en esta caso
         * y los metodos para mostrar*/
        event Action SeleccionarEvento;
        event Action Cerrar;

        IList<EventoDTO> Eventos { get; }
        int EventoSeleccionado { get; }

        void ListarEventos(IList<EventoDTO> eventos);
        void MostrarEvento(EventoDTO evento);
    }
}
