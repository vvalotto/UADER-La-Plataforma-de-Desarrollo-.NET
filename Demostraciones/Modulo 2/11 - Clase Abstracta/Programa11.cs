using System;

namespace Modulo_2
{
	class Programa11:Programa
	{
		internal override void Ejecutar()

		{
			Triangulo miTriangulo = new Triangulo ();

            miTriangulo.altura = 10;
            miTriangulo.baseT = 5;
			miTriangulo.InformarDatosGeometricos ();

			Console.ReadKey ();

		}
	}
}
