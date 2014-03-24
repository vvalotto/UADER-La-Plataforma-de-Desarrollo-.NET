using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int _opcion = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Programas Demos de la Módulo 2 - La Plataforma de Desarrollo.NET\n");
                Console.WriteLine("Seleccionar un tema:\n");

                Console.WriteLine("1 - Tipos Primitivos");
                Console.WriteLine("2 - Tipos Valor / Referencia");
                Console.WriteLine("3 - Lista de Tipos");
                Console.WriteLine("4 - Declaracion de Constantes y Variables");
                Console.WriteLine("5 - Enumerados");
                Console.WriteLine("6 - Matrices y Arreglos");
                Console.WriteLine("7 - Estructuras");
                Console.WriteLine("8 - Clases");
                Console.WriteLine("9 - Clase Object");
                Console.WriteLine("10 - Ambito");
                Console.WriteLine("11 - Clase Abstracta");
                Console.WriteLine("12 - Interfaces");
                Console.WriteLine("13 - Excepciones");
                Console.WriteLine("14 - Eventos y Delegados");
                Modulo2.MostrarSeparador();
                Console.WriteLine("0 - Salir");
                Modulo2.MostrarSeparador();
                Console.Write("Opción >");

                try
                {
                    _opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingreso incorrecto. Intente de Nuevo");
                    _opcion = -1;
                }

                switch (_opcion)
                {
                    case 1:
                        Modulo2.MostrarTituloDemo("Demo de Tipos Primitivos");
                        Modulo2.EjecutarPrograma(new Programa01());
                        break;
                    case 2:
                        Modulo2.MostrarTituloDemo("Demo de Tipos Valor y Referencia");
                        Modulo2.EjecutarPrograma(new Programa02());
                        break;
                    case 3:
                        Modulo2.MostrarTituloDemo("Demo de Tipos Valor y Referencia - 2");
                        Modulo2.EjecutarPrograma(new Programa03());
                        break;
                    case 4:
                        Modulo2.MostrarTituloDemo("Demo de Declaracion de Constantes y Variables");
                        Modulo2.EjecutarPrograma(new Programa04());
                        break;
                    case 5:
                        Modulo2.MostrarTituloDemo("Demo de Enumeración - Caso A");
                        Modulo2.EjecutarPrograma(new Programa05a());
                        Modulo2.MostrarTituloDemo("Demo de Enumeración - Caso B");
                        Modulo2.EjecutarPrograma(new Programa05b());
                        break;
                    case 6:
                        Modulo2.MostrarTituloDemo("Demo de Matrices y Arreglos");
                        Modulo2.EjecutarPrograma(new Programa06());
                        break;
                    case 7:
                        Modulo2.MostrarTituloDemo("Demo de Estructuras - A");
                        Modulo2.EjecutarPrograma(new Programa07a());
                        Modulo2.MostrarTituloDemo("Demo de Estructuras - B");
                        Modulo2.EjecutarPrograma(new Programa07b());
                        break;
                    case 8:
                        Modulo2.MostrarTituloDemo("Demo de Clases - Definición");
                        Modulo2.EjecutarPrograma(new Programa08a());
                        Modulo2.MostrarTituloDemo("Demo de Clases - Instaciación");
                        Modulo2.EjecutarPrograma(new Programa08b());
                        break;
                    case 9:
                        Modulo2.MostrarTituloDemo("Demo de Clase Object");
                        Modulo2.EjecutarPrograma(new Programa09());
                        break;
                    case 10:
                        Modulo2.MostrarTituloDemo("Demo de Ambito - A");
                        Modulo2.EjecutarPrograma(new Programa10a());
                        Modulo2.MostrarTituloDemo("Demo de Ambito - B");
                        Modulo2.EjecutarPrograma(new Programa10b());
                        break;
                    case 11:
                        Modulo2.MostrarTituloDemo("Demo de Clase Abstracta");
                        Modulo2.EjecutarPrograma(new Programa11());
                        break;
                    case 12:
                        Modulo2.MostrarTituloDemo("Demo de Interfaces - Usuario");
                        Modulo2.EjecutarPrograma(new Programa12a());
                        Modulo2.MostrarTituloDemo("Demo de Interfaces - Framework");
                        Modulo2.EjecutarPrograma(new Programa12b());
                        break;
                    case 13:
                        Modulo2.MostrarTituloDemo("Demo de Exepciones - A");
                        Modulo2.EjecutarPrograma(new Programa13a());
                        Modulo2.MostrarTituloDemo("Demo de Exepciones - B");
                        Modulo2.EjecutarPrograma(new Programa13b());
                        Modulo2.MostrarTituloDemo("Demo de Exepciones - C");
                        Modulo2.EjecutarPrograma(new Programa13c());
                        break;
                    case 14:
                        Modulo2.MostrarTituloDemo("Demo de Eventos");
                        Modulo2.EjecutarPrograma(new Programa14a());
                        Modulo2.MostrarTituloDemo("Demo de Delegados");
                        Modulo2.EjecutarPrograma(new Programa14b());
                        break;
                }      

            } while (_opcion != 0);

        }
    }

    static internal class Modulo2
    {
        static internal void MostrarTituloDemo(string titulo)
        {
            Console.Clear();
            Console.WriteLine(titulo);
        }

        static internal void MostrarSeparador()
        {
            Console.WriteLine("----------------------------\n");
        }

        static internal void EjecutarPrograma (Programa p)
        {
            p.Ejecutar();
        }
    }

    internal abstract class Programa
    {
        internal abstract void Ejecutar();
    }

}
