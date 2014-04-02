using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_3
{
    internal class Programa01c : Programa
    {
        internal override void Ejecutar()
        {
            IList<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("Juan", "Perez"));
            clientes.Add(new Cliente("Pedro", "Gomez"));
            clientes.Add(new Cliente("Piojo", "Lopez"));

            // Se puede recorrer con un For o con un Foreach
            for (int i = 0; i <= clientes.Count - 1; i++)
            {
                Console.WriteLine(clientes[i].ToString());
            }
            Console.ReadKey();

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
            Console.ReadKey();
        }
    }

}
