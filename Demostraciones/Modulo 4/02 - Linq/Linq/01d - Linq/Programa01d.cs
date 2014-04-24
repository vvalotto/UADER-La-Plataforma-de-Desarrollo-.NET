using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_4
{
    class Programa01d:Programa
    {
        internal override void Ejecutar()
        {

            var ctx = new ProyectosDataContext();
            ManejadorProyectos ManProyectos = new ManejadorProyectos();

            var proyectos = from p in ctx.Proyectos
                           select p;
            var Clientes = from c in ctx.Clientes
                           select c;

            var DatosProyectos = from p in ctx.Proyectos
                                 join c in ctx.Clientes
                                 on p.IDCliente equals c.Id
                                 select new
                                 {
                                     cliente = c.Nombre,
                                     proyecto = p.Titulo
                                 };

            foreach (var p in proyectos)
            {
                Console.WriteLine(p.Titulo);
            }
            
            foreach (var c in Clientes)
            {
                Console.WriteLine(c.Nombre);
            }

            foreach (var dp in DatosProyectos)
            {
                Console.WriteLine(dp.cliente + " - " + dp.proyecto);
            }
            Console.ReadKey();
        }
    }
}
