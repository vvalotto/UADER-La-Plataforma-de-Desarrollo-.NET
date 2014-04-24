using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Modulo_4
{
    internal class Programa01b:Programa
    {
        internal override void Ejecutar()
        {
       
            #region Ejemplo Básico de LINQ a Objetos 2
            //Lista de strings
            string[] colores =
            {
            "Red",
            "Brown",
            "Orange",
            "Yellow",
            "Black",
            "Green",
            "White",
            "Violet",
            "Blue"
            };

            //Inicializa una lista de objetos
            Autos _listaAutos = new Autos();
            Console.WriteLine("Muestra lista completa de objetos");
            _listaAutos.MostrarLista();

            //Filtra la lista de colors y 
            IEnumerable<Auto> _resultado =   from c in colores
                                             where c.Length == 5
                                             orderby c
                                             select new Auto()
                                             {
                                                 Marca = "Ford",
                                                 Color = c 
                                             };
            Console.WriteLine("");
            Console.WriteLine("La lista de autos con LINQ es:");
            foreach (Auto a in _resultado)
            {
                Console.WriteLine(a);
            }


            #endregion
         

            Console.ReadKey();

        }
    }
}
