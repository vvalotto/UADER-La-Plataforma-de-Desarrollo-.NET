using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    //Definición de una estructura
    public struct Punto
    {
        public int x;
        public int y;

        //Nuevo Constructor
        public Punto(int xPunto, int yPunto)
        {
            this.x = xPunto;
            this.y = yPunto;
        }
        //Sobrecarga de ToString
        public override string ToString()
        {
            return (String.Format("({0},{1})", x, y));
        }
    }

    class Programa07a:Programa
    {
        internal override void Ejecutar()
        {
            Modulo2.MostrarTituloDemo("\nInicio Estructuras A\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();
        }

        class ClaseEjemplo
        {
        }
    }
}
