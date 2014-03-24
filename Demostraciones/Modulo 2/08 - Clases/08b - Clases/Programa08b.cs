using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa08b:Programa
    {

        //Constructores
        public Programa08b()
        {
        }

        public Programa08b (string nuevoNombre)
        {
            this._nombreValue = nuevoNombre;
        }

        // Miembros campo y propiedad
        private string _nombreValue = string.Empty;
        public string nombre
        {
            get
            {
                return _nombreValue;
            }
            set
            {
                _nombreValue = value;
            }
        }

        public void Saludar()
        {
            Console.WriteLine("Bienvenidos a Paraná");
        }

        public void Saludar(string slogan)
        {
            Console.WriteLine(slogan);
        }

        public void Saludar(string slogan, int temporada)
        {
            Console.WriteLine (slogan + " - " + temporada.ToString());
        }

        public string Saludar(int valor)
        {
            return "Este año " + valor.ToString() + " será el mejor.";
        }

        internal override void Ejecutar()
        {
            Modulo2.MostrarTituloDemo("\nInicio Instanciacion de Clases A\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();
        }
    }
}
