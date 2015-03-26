using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa02:Programa
    {
        internal override void Ejecutar()
        {
            //1. Declaración por valor
            int numeroEntero;
            numeroEntero = 10; //Se asigna el valor 10 a la variable entera 
            
            int numeroEnteroB;
            
            numeroEnteroB = numeroEntero; //Se asigna el valor contenido en una variabla a otra
            Console.WriteLine("num 1 {0} - num 2 {1}", numeroEntero, numeroEnteroB);

            //2. Declaracion por referencia
            object tipoRef;
            
            tipoRef = numeroEntero; //Se asigna la dirección de memoria de la variable numeroEntero
            object tipoRefB;
            tipoRefB = tipoRef;

            Console.WriteLine("objeto {0}", tipoRef);
            Console.WriteLine(tipoRef.GetType());
            Console.WriteLine("objeto B {0}", tipoRefB);
            Console.WriteLine(tipoRefB.GetType());
            Console.WriteLine("objeto y objeto B son iguales? {0}", (tipoRef == tipoRefB));

            tipoRef = "Hola";
            Console.WriteLine("objeto {0}", tipoRef);
            Console.WriteLine(tipoRef.GetType());

            MiClase c = new MiClase();
            c.cadena = "aaaa";
            tipoRefB = c;
            Console.WriteLine("objeto {0}", tipoRefB.ToString());
            Console.WriteLine(tipoRefB.GetType());

            Console.ReadKey();

        }
    }

    class MiClase
    {
        public string cadena;

        public override string ToString()
        {
            return cadena;
        }
    }
}
