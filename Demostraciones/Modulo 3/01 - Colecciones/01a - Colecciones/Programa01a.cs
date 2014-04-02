using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Modulo_3
{
    internal class Programa01a:Programa
    {
        internal override void Ejecutar()
        {
            #region Colecciones que implementan ICollection

            //1. Implementacion de Stack (Generics)
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            
            Console.WriteLine("Colección Stack (LIFO)");
            for (int i = 0; i < 4; i++)
            {
                int valor = stack.Pop();
                Console.WriteLine(valor);
            }


            Console.WriteLine("Presione una tecla para continuar...");

            Console.ReadKey(true);

            //1. Implementacion de Queue (Generics)
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine("Colección Queue (FIFO)");
            for (int i = 0; i < 4; i++)
            {
                int valor = queue.Dequeue();
                Console.WriteLine(valor);
            }

            Console.WriteLine("Presione una tecla para continuar...");

            Console.ReadKey(true);

            #endregion Colecciones que implementan ICollection

            #region Colecciones que implementan IList
            Console.WriteLine("Colección IList");

            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Colección IList - Removiendo elemento*");
            lista.RemoveAt(2);

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            /*
            Console.WriteLine("Colección IList - Con error de conversion");
            try
            {
                foreach (DateTime i in lista)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            */
             
            Console.WriteLine("Presione una tecla para continuar...");

            Console.ReadKey(true);

            #endregion Colecciones que implementan IList

            #region Colecciones que implementan IDictionary

            Console.WriteLine("Colección Dictionary");
            IDictionary<int, string> diccionario = new Dictionary<int, string>(); ;
            diccionario.Add(1, "Juan");
            diccionario.Add(2, "Lucas");
            diccionario.Add(3, "Pablo");
            diccionario.Add(4, "Pedro");

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(diccionario[i]);
            }

            Console.WriteLine("Presione una tecla para continuar...");

            Console.ReadKey(true);

            #endregion Colecciones que implementan IDictionary
        }
    }
}
