using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;

namespace IronManMVCBasico
{
    class VistaEvento
    {
        public void MostrarListaEventos(IList<EventoDTO> eventos)
        {
            
            foreach (EventoDTO e in eventos)
            {
                Console.WriteLine("> Nombre: {0}", e.Nombre);
                Console.WriteLine("> Lugar: {0}", e.Lugar);
                Console.WriteLine("> Fecha: {0}", e.Fecha.ToString());
                Console.WriteLine("> Comentario: {0}", e.Comentario);
                Console.WriteLine("------------------------");
            }

        }
    }
}
