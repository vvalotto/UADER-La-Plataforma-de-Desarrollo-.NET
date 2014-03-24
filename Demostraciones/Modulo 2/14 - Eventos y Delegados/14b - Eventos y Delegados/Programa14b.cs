using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa14b:Programa
    {
        delegate void Saludar(string Nombre);
        
        public Programa14b()
        {
            Saludar Saludo = new Saludar(MostrarSaludo);
            Saludo += new Saludar(SaludoDespedir);
            Saludo("Alejo");
            Saludo -= new Saludar(SaludoDespedir);
            Saludo("Alejo");     
        }

        private void MostrarSaludo (string Nombre)
        {
            Console.WriteLine("Hola {0}", Nombre);
        }

        private void SaludoDespedir(string Nombre)
        {
            Console.WriteLine("Adios {0}", Nombre);
        }
                
        internal override void Ejecutar()
        {
            Modulo2.MostrarTituloDemo("\nInicio Delegados\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();
        }
    }
}
