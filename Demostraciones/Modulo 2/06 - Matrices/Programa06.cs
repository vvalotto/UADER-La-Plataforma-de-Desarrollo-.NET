using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa06:Programa
    {
        internal override void Ejecutar()
        {
            //1. Declaracion de Arreglos
            int[] numeroEnteros = new int[15];

            //2. Inicialización de Arreglos
            string[] nombre = new string[] { "Victor", "Diego", "Marcos" };
            Console.WriteLine(nombre.Length);
            Array.Sort(nombre);

            foreach (string c in nombre)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();

            //3. Los arreglos son objetos manejado por referencias
            string[] listaNombre1 = nombre;
            string[] listaNombre2 = new string[nombre.Length];
            nombre.CopyTo(listaNombre2,0);

            //4. Muestra el contenido del arreglo original
            Console.WriteLine("Original ");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }
            Console.ReadKey();

            //5. Cambia el contenido de la posicion 1.
            nombre[1] = "Miguel";

            //6. Muestra el contenido del arreglo modificado
            Console.WriteLine("Original Modificado");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }
            Console.ReadKey();

            //7. Muestra el contenido del arreglo asignado por referencia
            Console.WriteLine("Arreglo 2 - asignado por referencia");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(listaNombre1[i]);
            }
            Console.ReadKey();

            //8. Muestra el contenido del arreglo copiado
            Console.WriteLine("Arreglo 3 - Copia del Original");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(listaNombre2[i]);
            }
            Console.ReadKey();

          
        }
    }
}
