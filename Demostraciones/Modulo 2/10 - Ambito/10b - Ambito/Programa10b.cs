using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa10b:Programa
    {
        internal override void Ejecutar()
        {
            Modulo2.MostrarTituloDemo("\nInicio Ambito B\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();
        }

    }

    public class Humano
    {
        protected string nombre = string.Empty;
    }

    public class cliente : Humano
    {
        public cliente()
        {
            this.nombre = "Sin nombre";
        }
    }
}
