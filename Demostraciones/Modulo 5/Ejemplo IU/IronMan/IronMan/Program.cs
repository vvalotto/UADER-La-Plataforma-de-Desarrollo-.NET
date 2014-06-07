using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.IronManEventoServicio;

namespace IronMan
{
    class Program
    {
        static void Main(string[] args)
        {

            IronManEventoServicio.EventoServicioClient _servicio = new IronManEventoServicio.EventoServicioClient();

            Console.WriteLine(_servicio.ObtenerNombreEvento(1));
            var eventos = _servicio.Listar().ToList();

            foreach (Evento e in eventos)
            {
                Console.WriteLine("> Nombre: {0}", e.Nombre);
                Console.WriteLine("> Lugar: {0}", e.Lugar);
                Console.WriteLine("> Fecha: {0}", e.Fecha.ToString());
                Console.WriteLine("> Comentario: {0}", e.Comentario);
                Console.WriteLine("------------------------");
            }

            Console.ReadKey();
        }
    }
}
