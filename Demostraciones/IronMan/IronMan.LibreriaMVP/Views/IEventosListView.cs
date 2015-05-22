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
        event Action SeleccionarEvento;
        event Action Cerrar;

        IList<EventoDTO> Eventos { get; }
        int EventoSeleccionado { get; }

        void ListarEventos(IList<EventoDTO> eventos);
        void MostrarEvento(EventoDTO evento);
    }
}
