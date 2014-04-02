using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_3
{
    class Programa02b:Programa
    {
        internal override void Ejecutar()
        {
            #region Constantes

            const string archivo = @"c:\Temp\streams.txt";
            const string cadena = "Ejemplo de guardar datos utilizando clases basadas en stream";

            #endregion

            #region Guardar archivo
            Console.WriteLine("Guardando datos");
            // Abrimos o creamos el fichero, para escribir en él
            System.IO.FileStream fsWrite = new System.IO.FileStream(archivo,
                                System.IO.FileMode.OpenOrCreate,
                                System.IO.FileAccess.Write);
            // Escribimos algunas cadenas,
            // el problema es que solo podemos escribir arrays de bytes,
            // por tanto debemos convertir la cadena en un array de bytes
            byte[] datosWrite;
            // pero usando la codificación que creamos conveniente
            // de forma predeterminada es UTF-8
            System.Text.UTF8Encoding encWrite = new System.Text.UTF8Encoding();
            // convertimos la cadena en un array de bytes
            datosWrite = encWrite.GetBytes(cadena);
            // lo escribimos en el stream
            fsWrite.Write(datosWrite, 0, datosWrite.Length);
            // nos aseguramos que se escriben todos los datos
            fsWrite.Flush();
            // cerramos el stream
            fsWrite.Close();


            #endregion

            #region Leer archivo
            Console.WriteLine("Leyendo datos");
            // Los bloques leídos los almacenaremos en un StringBuilder
            System.Text.StringBuilder res = new System.Text.StringBuilder();
            // Abrimos el fichero para leer de él
            System.IO.FileStream fs = new System.IO.FileStream(archivo, 
                                System.IO.FileMode.Open, 
                                System.IO.FileAccess.Read);
            // los datos se leerán en bloques de 1024 bytes (1 KB)
            byte[] datos = new byte[1025];
            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            // Para usar la codificación de Windows
            //System.Text.Encoding enc = System.Text.Encoding.Default;
            // leemos mientras hay algo en el fichero
            while (fs.Read(datos, 0, 1024) > 0)
            {
                // agregamos al stringBuilder los bytes leídos
                // (convertidos en una cadena)
                res.Append(enc.GetString(datos));
            }
            // cerramos el buffer
            fs.Close();
            // devolvemos todo lo leído
            Console.WriteLine(res.ToString());
            Console.ReadLine();

            #endregion 
        }
    }
}
