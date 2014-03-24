using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
     class Person
        {
            public int i;
            public string s;

            public Person (int pi, string ps)
            {
                i = pi;
                s = ps;
            }
        }

    class Programa09:Programa
    {


        internal override void Ejecutar()
        {
            Modulo2.MostrarTituloDemo("\nInicio Clase Object A\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();

        }
    }
}
