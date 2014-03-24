using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa02:Programa
    {
        internal override void Ejecutar()
        {
            //Definiciones de Tipo de datos primitivos
            Modulo2.MostrarTituloDemo("\nInicio Tipo Valor Referencia\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();


        }
    }

    class MiClase
    {
        public string cadena;

        public override string ToString()
        {
            return cadena;
        }
    }
}
