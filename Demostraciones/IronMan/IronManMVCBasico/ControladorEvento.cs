using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.Gestores;
using IronMan.DTO;

namespace IronManMVCBasico
{
    public class ControladorEvento
    {
        EventoGestor _eGestor = new EventoGestor();
        VistaEvento _eVista = new VistaEvento();

        public void ObtenerListaEventos()
        {
           IList<EventoDTO> ListaEventos = _eGestor.Listar();
           _eVista.MostrarListaEventos(ListaEventos);
        }
    }
}
