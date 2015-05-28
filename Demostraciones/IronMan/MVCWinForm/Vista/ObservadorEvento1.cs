using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinForm.Vista
{
    public class ObservadorEvento1:IVistaObservador
    {
        public string NombreObservador { get; private set; }
        
        public ObservadorEvento1()
        {
            this.NombreObservador = "Observador Evento 1";
        }

        public void Actualizar(string tipoActualizacion)
        {
            Console.WriteLine("{0}:{1} ", this.NombreObservador, tipoActualizacion);
        }
    }
}
