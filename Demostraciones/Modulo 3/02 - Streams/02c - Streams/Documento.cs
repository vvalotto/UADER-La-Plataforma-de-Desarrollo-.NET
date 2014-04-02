using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_3
{
    internal class Documento
    {
        #region Miembros Privados 
        string _titulo;
        string _ubicacion;
        IList<string> _texto = new List<string>();
        #endregion

        #region Propiedades
        internal string Titulo
        {
            set { _titulo = value; }
            get { return _titulo; }
        }

        internal string Ubicacion
        {
            set { _ubicacion = value; }
            get { return _ubicacion; }
        }
        #endregion

        #region Constructor
        //Inicializa los datos internos
        internal Documento(string titulo, string ubicacion)
        {
            _titulo = titulo;
            _ubicacion = ubicacion;
        }
        #endregion

        #region Metodos No privados
        //Muestra el texto en consola
        internal void MostrarTexto()
        {
            if (_texto.Count == 0)
            {
                Console.WriteLine("Texto sin Contenido");
            }
            else
            {
                foreach (string s in _texto)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }

        //El Texto ingresado por consola se va agregando a la lista
        internal void IngresarTexto()
        {
            string _linea;

            Console.Clear();
            Console.WriteLine("Ingrese el un texto cualquiera. Dos veces Enter para salir");
            do
            {
                _linea = Console.ReadLine();
                if (_linea != "")
                {
                    this.LlenarTexto(_linea);
                }
            } while (_linea != "");
        }

        //Se Guarda el Texto en al archvo
        internal void GuardarTexto()
        {
            if (_texto.Count == 0)
            {
                Console.WriteLine("Texto sin Contenido");
            }

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(_ubicacion + _titulo + ".txt", true))
                {
                    foreach (string s in _texto)
                    {
                        file.WriteLine(s);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.TargetSite);
            }
        }
        
        //Obtiene el contenido del archivo
        internal void RecuperarTexto()
        {
            if (_texto.Count !=0)
            {
                _texto.Clear();
            }

            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(_ubicacion + _titulo + ".txt", true))
                {
                    string linea;

                   while ((linea = file.ReadLine()) != null)
                   {
                       this.LlenarTexto(linea);
                   }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.TargetSite);
            }
        }
        
        #endregion

        #region Metodos Privados
        //Agrega lineas de texto - llena con string la lista
        private void LlenarTexto(string texto)
        {
            _texto.Add(texto);
        }
        #endregion
    }
}
