using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronManMVCBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorEvento _eControlador = new ControladorEvento();
            _eControlador.ObtenerListaEventos();
            Console.ReadKey();

        }
    }
}
