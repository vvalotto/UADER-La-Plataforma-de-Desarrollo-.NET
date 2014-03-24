using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa08a:Programa
    {
        internal override void Ejecutar()

        {
            Modulo2.MostrarTituloDemo("\nInicio Definicion de Clases\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();
        }
        
    }

    class MiPrimeraClase
    {
        //Miembro de la clase
        //1. Campos o artibutos
        public string nombre = "Victor";

        //2. Propiedad
        private int _edad = 0;

        public int edad
        {
            get
            {
                return _edad;
;
            }
            set
            {
                _edad = value;
            }
        }

        //3. Metodos
        public void MiInfo()
        {
            Console.WriteLine(nombre + " tiene " + edad + " años.");
        }

        public string MiInfo(string nombre, int edad)
        {
            return nombre + " tiene " + edad + " años.";
        }

        //4. Propiedad Indexador 
        private string[] _nombreDocentes = new string[] { "Diego", "Marcos", "Victor" };
        public string this[int index]
        {
            get 
            {
                return _nombreDocentes[index];
            }
            set
            {
                _nombreDocentes[index] = value;
            }
        }

        public void listarDocentes()
        {
            foreach (string i in _nombreDocentes)
            {
                Console.WriteLine(i);
            }
         }

    }

    public sealed class AlgunTipo //1
    { 
        // Clase Anidada
        private class AlgunTipoAnidado { } // 2

        // Constante, solo lectura, y estátic
        private const Int32 c_Contante = 1; // 3
        private readonly String m_SoloLectura = "2"; // 4
        private static Int32 s_CampoEstatico = 3; // 5

        // Type constructor
        static AlgunTipo() { } // 6

        // Instance constructors
        public AlgunTipo(Int32 x) { } // 7
        public AlgunTipo() { } // 8

        // Metodos de Instancia y estáticos
        private String Metodo() { return null; } // 9
        //public static void Main() { } // 10

        // Propiedad de Instancia
        public Int32 Propiedad
        { // 11
            get { return 0; } // 12
            set { } // 13
        }
        // Propiedad de Instancia parametrizada (indexer)
        public Int32 this[String s]
        { // 14
            get { return 0; } // 15
            set { } // 16
        }
        // Evento de Instancia
        public event EventHandler Evento; // 17
    }
}
