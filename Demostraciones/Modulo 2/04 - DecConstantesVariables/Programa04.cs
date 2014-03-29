using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa04:Programa
    {
        internal override void Ejecutar()
        {

            //Declaracion de Variables
            //int a;
            //a = 10;
            int a = 10;

            //int numeroEnteroA, numeroEnteroB;
            int numeroEnteroA = 10, numeroEnteroB = 5;
 
            //Declaracion de Constantes
            const int numeroConstante = 10;
 
            //Tipos anónimos
            var persona = new { Nombre = "Victor", Edad = 49 };
            Console.WriteLine ("Nombre:  "  + persona.Nombre + " - " + " Edad: " + Convert.ToString(persona.Edad));
            Console.ReadKey();

            //Tipo Nullable
            int? number = null;
            Nullable<int> number2 = null;

            if (number.HasValue == true)
            {
                Console.WriteLine(number.ToString());
            }
            else
            {
                Console.WriteLine("El valor es nulo");
            }
            Console.ReadKey();

        }
    }
}
