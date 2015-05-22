using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.IronManEventoServicio;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using IronMan.Logging;

namespace IronMan
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfiguracionLogger _configLog = new ConfiguracionLogger("Hola");
            

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
