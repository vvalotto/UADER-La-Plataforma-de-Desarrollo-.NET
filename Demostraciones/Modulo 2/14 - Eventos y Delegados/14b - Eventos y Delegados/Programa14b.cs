using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa14b:Programa
    {
        delegate void Saludar(string Nombre);
        
        internal override void Ejecutar()
        {
            Saludar Saludo = new Saludar(MostrarSaludo);

            Saludo += new Saludar(SaludoDespedir);
            Saludo("Alejo");
            Console.ReadKey();

            Saludo -= new Saludar(SaludoDespedir);
            Saludo("Alejo");   
            Console.ReadKey();
        }

        private void MostrarSaludo (string Nombre)
        {
            Console.WriteLine("Hola {0}", Nombre);
        }

        private void SaludoDespedir(string Nombre)
        {
            Console.WriteLine("Adios {0}", Nombre);
        }
               
    }
}
