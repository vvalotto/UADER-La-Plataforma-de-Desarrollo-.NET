using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa14a:Programa
    {
       

        public Programa14a()
        {
            Empleados emp = new Empleados   ("Jose", "Perez", 34);
            emp.DatosCambiados += new Empleados.DatosCambiadosEventHandler(emp_DatosCambiados);
            emp.Nombre = "Nuevo Nombre";
            Console.WriteLine(emp.ToString());

        }

        private void emp_DatosCambiados()
        {
            Console.WriteLine("Los datos fueron cambiados");
        }

         internal override void Ejecutar()
        {
            Modulo2.MostrarTituloDemo("\nInicio Eventos\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();
        }

    }

    class Empleados
    {
        public delegate void DatosCambiadosEventHandler();
        public event DatosCambiadosEventHandler DatosCambiados;

        private string _nombre = string.Empty;
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
                if (DatosCambiados != null)
                {
                    DatosCambiados();
                }
            }
        }

        private string _apellidos = string.Empty;
        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }

        private int _edad = 0;
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
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
