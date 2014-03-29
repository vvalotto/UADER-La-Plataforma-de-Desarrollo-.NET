using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    //Definición de una estructura
    public struct Punto
    {
        public int x;
        public int y;

        //Nuevo Constructor
        public Punto(int xPunto, int yPunto)
        {
            this.x = xPunto;
            this.y = yPunto;
        }
        //Sobrecarga de ToString
        public override string ToString()
        {
            return (String.Format("({0},{1})", x, y));
        }
    }

    class Programa07a:Programa
    {
        internal override void Ejecutar()
        {

            //Instanciacion
            Punto p ;
          
            p.x = 10;
            p.y = 10;

            //Nueva Instancia
            Punto p1 = new Punto(0,0);
            Console.WriteLine("Antes");
            Console.WriteLine(p.ToString());
            Console.WriteLine(p1.ToString());

            //Asignacion de instancias
            p1 = p;
            Console.WriteLine("Despues");
            Console.WriteLine(p.ToString());
            Console.WriteLine(p1.ToString());
            Console.ReadLine();

            //Ejecicio de ReferenceEquals - Estructuras
            if (ReferenceEquals(p, p1))
                Console.WriteLine("Tienen la misma dirección de memoria");
            else
                Console.WriteLine("No tiene las misma dirección de memoria");
            Console.ReadLine();
                      

            //Ejecicio de ReferenceEquals - Clase 
            ClaseEjemplo ClaseA = new ClaseEjemplo();
            ClaseEjemplo ClaseB = new ClaseEjemplo();
            ClaseA = ClaseB;
            if (ReferenceEquals(ClaseA, ClaseB))
                Console.WriteLine("Tienen la misma dirección de memoria");
            else
                Console.WriteLine("No tiene las misma dirección de memoria");
            Console.ReadLine();

        }

        class ClaseEjemplo
        {
        }
    }
}
