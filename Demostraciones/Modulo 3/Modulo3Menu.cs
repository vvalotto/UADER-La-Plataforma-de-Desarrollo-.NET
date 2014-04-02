using System;

namespace Modulo_3
{
	static public class Modulo3Menu
	{

		static public void MostrarMenu()
		{
			int _opcion = -1;

			do
			{
				Console.Clear();
				Console.WriteLine("Programas Demos de la Módulo 2 - La Plataforma de Desarrollo.NET\n");
				Console.WriteLine("Seleccionar un tema:\n");

				Console.WriteLine("1 - Colecciones");
                Console.WriteLine("2 - Streams");
				Console.WriteLine("3 - Archivos y Directorios");
				Console.WriteLine("4 - Acceso a Redes");

				Console.WriteLine("0 - Salir");

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
					Modulo3.MostrarTituloDemo("Demo de Colecciones - Colecciones de Datos");
					Modulo3.EjecutarPrograma(new Programa01a());
                    Modulo3.MostrarTituloDemo("Demo de Colecciones - IList");
					Modulo3.EjecutarPrograma(new Programa01b());
                    Modulo3.MostrarTituloDemo("Demo de Colecciones - List Generics");
					Modulo3.EjecutarPrograma(new Programa01c());
					break;
				case 2:
                    Modulo3.MostrarTituloDemo("Demo de Streams - FileStream Basico");
                    Modulo3.EjecutarPrograma(new Programa02a());
                    Modulo3.MostrarTituloDemo("Demo de Streams - FileStream IList");
                    Modulo3.EjecutarPrograma(new Programa02b());
                    Modulo3.MostrarTituloDemo("Demo de Streamwriter y StreamReader");
					Modulo3.EjecutarPrograma(new Programa02c());
					break;
				case 3:
                    Modulo3.MostrarTituloDemo("Demo de Archivos");
					Modulo3.EjecutarPrograma(new Programa03a());
                    Modulo3.MostrarTituloDemo("Demo de Archivos");
					Modulo3.EjecutarPrograma(new Programa03b());
					break;
				case 4:
                    Modulo3.MostrarTituloDemo("Demo de Acceso - Internet");
                    Modulo3.EjecutarPrograma(new Programa04a());
                    //Modulo3.MostrarTituloDemo("Demo de Acceso - FTP");
                    //Modulo3.EjecutarPrograma(new Programa04b());
					break;
				}      

			} while (_opcion != 0);
		}

	}

	static internal class Modulo3
	{
		static internal void MostrarTituloDemo(string titulo)
		{
			Console.Clear();
			Console.WriteLine(titulo);
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

