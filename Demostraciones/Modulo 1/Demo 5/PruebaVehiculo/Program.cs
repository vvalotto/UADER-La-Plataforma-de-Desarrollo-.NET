using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjemploIntegracion;

namespace PruebaVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();

            Console.WriteLine("PRUEBA: Libreria Vehiculo");
            Console.WriteLine("-------------------------");

            v.DoblarDerecha();
            v.DoblarIzquierda();

            Console.WriteLine("Una tecla para continuar >");
            Console.ReadKey();
        }
    }
}
