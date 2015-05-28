using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;
using MVCWinForm.Controlador;

namespace MVCWinForm.Vista
{
    public interface IVistaListarEvento: IVista
    {
        
        void EjecutarListarEventos();

        void EjecutarMostarEvento(int id);

        void ListarEventos(IList<EventoDTO> lista);

        void MostrarEventos(EventoDTO evento);
    }
}
