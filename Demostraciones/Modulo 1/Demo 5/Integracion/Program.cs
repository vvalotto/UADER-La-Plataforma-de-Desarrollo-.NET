using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EjemploIntegracion;
using IntegracionAuto;
using IntegracionAvion;

namespace Integracion
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();
            Auto a = new Auto();
            Avion p = new Avion();

            v.DoblarDerecha();
            v.DoblarIzquierda();

            a.DoblarDerecha();
            a.DoblarIzquierda();

            p.DoblarDerecha();
            p.DoblarIzquierda();

            Console.ReadLine();
        }
    }
}
