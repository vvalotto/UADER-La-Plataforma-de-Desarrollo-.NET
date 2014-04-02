using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_3
{
    internal class Programa01b : Programa
    {
        internal override void Ejecutar()
        {
            Clientes clientes = new Clientes();

            clientes.Add(new Cliente("Juan", "Perez"));
            clientes.Add(new Cliente("Pedro", "Gomez"));
            clientes.Add(new Cliente("Piojo", "Lopez"));

            Console.WriteLine("Muestra la lista de clientes agregados.");
            // Se puede recorrer con un For o con un Foreach
            for (int i = 0; i <= clientes.Count - 1; i++)
            {
                Console.WriteLine(clientes[i].ToString());
            }
            Console.ReadKey();

            
            foreach(Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }

            Console.WriteLine("Muestra la lista de clientes ordenada.");
            clientes.Sort();
            foreach(Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }

            Console.ReadKey();
        }
    }

   
    /// <summary>
    /// Colección de tipo Cliente basada en IList
    /// </summary>
    /// <remarks></remarks>
    internal class Clientes : System.Collections.CollectionBase
    {
        public int Add(Cliente value)
        {
            return List.Add(value);
        }

        public bool Contains(Cliente value)
        {
            return List.Contains(value);
        }

        public int IndexOf(Cliente value)
        {
            return List.IndexOf(value);
        }

        public void Insert(int index, Cliente value)
        {
            List.Insert(index, value);
        }

        public Cliente this[int index]
        {
            get
            {
                return (Cliente)List[index];
            }
            set
            {
                List[index] = value;
            }
        }

        public void Remove(Cliente value)
        {
            List.Remove(value);
        }

        public void Sort()
        {
            InnerList.Sort();
        }

    }
}
