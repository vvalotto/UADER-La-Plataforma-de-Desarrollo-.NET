using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_3
{
    /// <summary>
    /// Clase Cliente
    /// </summary>
    /// <remarks>
    /// Esta clase se puede clasificar por el campo Apellidos
    /// </remarks>
    internal class Cliente : System.IComparable
    {
        string _nombre;
        string _apellidos;

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }


        public string Apellidos
        {
            set { _apellidos = value; }
            get { return _apellidos;  }
        }

        public Cliente(string nombre)
        {
            this._nombre = nombre;
        }

        public Cliente(string nombre, string apellidos)
        {
            this._nombre = nombre;
            this._apellidos = apellidos;
        }

        public override string ToString()
        {
            return _apellidos + ", " + _nombre;
        }

        public int CompareTo(object obj)
        {
            if (obj is Cliente)
            {
                Cliente cli = (Cliente)obj;
                return string.Compare(this._apellidos, cli._apellidos);
            }
            else
                return 0;
        }
    }
}
