using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsolaCliente.ClienteService;

namespace ConsolaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new ClienteServiceClient();

            Console.WriteLine("Inicio del cliente");
            Console.WriteLine("Crea el objeto nuevo");

            var nuevoCliente = new Clientes
            {
                IDCliente = 99,
                Nombre = "Municipalidad de Parana",
                IDContacto = 1,
                Web = "www.parana.gov.ar",
                Calle = "Calle",
                Numero = "1",
                Pais = "Ninguno",
                Departamento = "Depto",
                Telefono = "00101000",
                Cuidad = "Parana",
                Provincia = "Entre Ríos",
                Piso = "Piso"
            };

            var nuevoCliID = svc.InsertarCliente(nuevoCliente);
            
            Console.WriteLine("Nuevo Cliente ID:" + nuevoCliente);
            Clientes Cli = svc.GetCliente(nuevoCliID);

            Console.WriteLine("Nuevo Cliente Nombre:" + Cli.Nombre);
            Cli.Calle = "Monte Caseros";

            Clientes actCli = svc.ActualizarCliente(Cli);

            Console.ReadKey();

        }
    }
}
