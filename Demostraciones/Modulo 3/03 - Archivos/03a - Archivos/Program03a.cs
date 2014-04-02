using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Modulo_3
{
    class Programa03a:Programa
    {
        internal override void Ejecutar()
        {
            #region Existencia de Archivos

            ExisteArchivo(@"c:\Temp\test.txt");
            Console.ReadLine();

            #endregion

            #region Verificar propiedades de un archivo

            VerificarPropiedades(@"c:\Temp\auditor.txt");

            #endregion

        }

        static void ExisteArchivo(string archivo)
        {
            #region Utilizando la clase File

            //Utilizando opreador if
            Console.WriteLine("Trabajando con la clase File");
            if (File.Exists(archivo))
                Console.WriteLine("El archivo {0} existe", archivo);
            else
                Console.WriteLine("El archivo {0} NO existe", archivo);
            //Utilizando operador condicional ?:
            /*
            Console.WriteLine(File.Exists(archivo) ? 
                                String.Format("El archivo {0} existe", archivo) : 
                                String.Format("El archivo {0} NO existe", archivo));
            */
            #endregion 

            #region Utilizando la clase FileInfo
            Console.WriteLine("Trabajando con la clase FileInfo");
            FileInfo fileInfo = new FileInfo(archivo);
            if (fileInfo.Exists)
                Console.WriteLine("El archivo {0} existe", archivo);
            else
                Console.WriteLine("El archivo {0} NO existe", archivo);

            #endregion
        }

        static void VerificarPropiedades(string archivo)
        {
            FileInfo fileInfo = new FileInfo(archivo);
                
            //fileInfo.Encrypt();
            //fileInfo.Decrypt();
            FileAttributes atributos = fileInfo.Attributes;
            if ((atributos & FileAttributes.Encrypted) == FileAttributes.Encrypted)   
                Console.WriteLine("Archivo encriptado");
            else
                Console.WriteLine("Archivo No encriptado");
            Console.ReadKey();
        }
    }
}
