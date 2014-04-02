using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Modulo_3
{
    class Programa03b:Programa
    {
        internal override void Ejecutar()
        {
            #region Recorriendo directorios usando Directory
            Console.WriteLine("Recorriendo directorios usando Directory");
            string[] directorios = Directory.GetDirectories(@"c:\");

            for (int i = 0; i < directorios.Length - 1; i++)
            {
                Console.WriteLine(directorios[i]);
            }
            Console.ReadLine();

            #endregion

            #region Recorriendo directorios usando DirectoryInfo
            Console.WriteLine("Recorriendo directorios usando DirectoryInfo");
            DirectoryInfo directoryInfo = new DirectoryInfo(@"c:\");
            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

            for (int i = 0; i < directoryInfos.Length; i++)
            {
                Console.WriteLine("{0} último acceso el día: {1}", directoryInfos[i].FullName, directoryInfos[i].LastAccessTime.ToShortDateString());
            }

            Console.ReadLine();
            #endregion

            #region Creando directorio y recorriendo subdirectorios
            
            Console.WriteLine("Creando directorio y recorriendo subdirectorios");
            string directorio = @"c:\TempDirectory";
            Directory.CreateDirectory(directorio);
            DirectoryInfo dirInfo = new DirectoryInfo(directorio);
            for (int i = 1; i < 5; i++)
            {
                
                dirInfo.CreateSubdirectory(string.Format("Carpeta {0}", i));
            }

            DirectoryInfo[] tempDirectoryInfo = dirInfo.GetDirectories();

            for (int i = 0; i < tempDirectoryInfo.Length; i++)
            {
                Console.WriteLine("{0} se creó el día: {1}", tempDirectoryInfo[i].FullName, tempDirectoryInfo[i].CreationTime.ToShortDateString());
            }

            Console.ReadLine();

            #endregion

            #region Recorriendo archivos de un directorio
            Console.WriteLine("Recorriendo archivos de un directorio");
            DirectoryInfo directorioParaObtenerArchivos = new DirectoryInfo(@"c:\Temp");
            //Controlamos si existe para no generar una excepción
            if (directorioParaObtenerArchivos.Exists)
            {
                foreach (FileInfo file in directorioParaObtenerArchivos.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }

            Console.ReadLine();

            #endregion

        }
    }
}
