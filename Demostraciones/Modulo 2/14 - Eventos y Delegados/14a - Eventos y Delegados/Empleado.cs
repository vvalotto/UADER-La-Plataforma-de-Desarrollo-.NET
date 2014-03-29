using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_2
{
    class Empleados
    {
        //public delegate void DatosCambiadosEventHandler();
        //public event DatosCambiadosEventHandler DatosCambiados;

        public event EventHandler DatosCambiados;

        private string _nombre = string.Empty;

        public string Nombre
        {
            get {return _nombre;}

            set
            {
               _nombre = value;
               DatosCambiados(this, new EventArgs());
                //if (DatosCambiados != null)
                //{
                //    DatosCambiados();
                //}
            }
        }

        private string _apellidos = string.Empty;
        public string Apellidos
        {
            get
            { return _apellidos;}
            set
            { _apellidos = value;}
        }

        private int _edad = 0;
        public int Edad
        {
            get { return _edad;}
            set { _edad = value;}
        }

        public override string ToString()
        {
            return _apellidos + "," + _nombre;
        }

        public Empleados(string nombre, string apellidos, int edad)
        {
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._edad = edad;
        }

    }
}
