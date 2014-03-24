using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    public class Empleado : IComparable
    {
        public string Nombre;
        public Empleado() { }
        public Empleado(string nombre)
        {
            this.Nombre = nombre;
        }
        public int CompareTo(object obj)
        {
            if (obj is Empleado)
            {
                Empleado e1 = ((Empleado)obj);
                return String.Compare(this.Nombre, e1.Nombre);
            }
            else
                return 0;
        }
    }
    class Programa12b:Programa
    {
        internal override void Ejecutar()

        {
            Modulo2.MostrarTituloDemo("\nInicio Interfaces B\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();
        }
    }
}
