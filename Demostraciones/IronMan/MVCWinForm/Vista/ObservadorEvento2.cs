using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinForm.Vista
{
    public class ObservadorEvento2 : IVistaObservador
    {
        public string NombreObservador { get; private set; }

        public ObservadorEvento2()
        {
            this.NombreObservador = "Observador Evento 2";
        }

        public void Actualizar(string tipoActualizacion)
        {
            Console.WriteLine("{0}:{1} ", this.NombreObservador, tipoActualizacion);
        }
    }
}
