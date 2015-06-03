using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronManMVCBasico.ObserverPattern;

namespace IronManMVCBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Observado tienda = new Observado();
            Observador cliente1 = new Observador("Cliente 1");
            Observador cliente2 = new Observador("Cliente 2");

            tienda.Suscribir(cliente1);
            tienda.Suscribir(cliente2);

            tienda.AgregarProducto("Ipad");
            tienda.AgregarProducto("IWatch");

            Console.ReadLine();
        }
    }
}
