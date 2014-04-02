using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Modulo_3
{
    internal class Programa02a:Programa
    {
        internal override void Ejecutar()
        {
            ManejadorArchivos mArchivos = new ManejadorArchivos();
            string archivo = @"c:\Temp\test.txt";
            mArchivos.EscribirArchivo(archivo, "Ejemplo de guardar un stream en .net");

            Console.WriteLine(mArchivos.LeerArchivo(archivo));
            Console.ReadKey();
        }
    }

    #region Clase que maneja el acceso a archivos
    internal class ManejadorArchivos
    {

        public void EscribirArchivo(string archivo, string dato)
        {
            //Escribe en un archivo
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter stream = new StreamWriter(fs);
            try
            {
                stream.Write(dato);
                Console.WriteLine("Archivo guardado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            stream.Close();
            stream.Dispose();
        }

        public string LeerArchivo(string archivo)
        {
            //Lee desde un archivo
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);

            StreamReader stream = new StreamReader(fs);
            string datos = stream.ReadToEnd();
            stream.Close();

            return datos;
        }
    }
    #endregion

}
