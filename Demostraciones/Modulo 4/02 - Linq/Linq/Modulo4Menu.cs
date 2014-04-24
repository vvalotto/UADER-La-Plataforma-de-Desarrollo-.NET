using System;

namespace Modulo_4
{
	static public class Modulo4Menu
	{

		static public void MostrarMenu()
		{
			int _opcion = -1;

			do
			{
				Console.Clear();
				Console.WriteLine("Programas Demos de la Módulo 3 - La Plataforma de Desarrollo.NET\n");
				Console.WriteLine("Seleccionar un tema:\n");

				Console.WriteLine("1 - LINQ a Objetos - Basico ");
                Console.WriteLine("2 - LINQ a Objetos - Filtrado Basico");
                Console.WriteLine("3 - LINQ a Objetos - Lista de Objetos");
                Console.WriteLine("4 - LINQ a SQL - Consola");
                Console.WriteLine("5 - LINQ a SQL - CRUD");

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
                    Modulo4.MostrarTituloDemo("Demo de LINQ a Objetos");
                    Modulo4.EjecutarPrograma(new Programa01a());
					break;
				case 2:
                    Modulo4.MostrarTituloDemo("Demo de LINQ a Objetos 2");
                    Modulo4.EjecutarPrograma(new Programa01b());
					break;
				case 3:
                    Modulo4.MostrarTituloDemo("Demo de LINQ - Lista de Objetos");
                    Modulo4.EjecutarPrograma(new Programa01c());
                    break;
				case 4:
                    Modulo4.MostrarTituloDemo("Demo de LINQ - Consola");
					Modulo4.EjecutarPrograma(new Programa01d());
					break;
                case 5:
                    Modulo4.MostrarTituloDemo("Demo de LINQ - CRUD");
                    Modulo4.EjecutarPrograma(new Programa01e());
                    break;
				}      

			} while (_opcion != 0);
		}

	}

	static internal class Modulo4
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

