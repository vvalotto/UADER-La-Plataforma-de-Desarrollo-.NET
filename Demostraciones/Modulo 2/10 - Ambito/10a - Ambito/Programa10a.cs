using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa10a:Programa
    {
        
        int m = 0;//Ambito de la clase
        internal override void Ejecutar()
        {
            //.1 Ambito de Bloque
            //for (int i = 0; i <= 10; i++)
            //{
            //    i++; //Dentro del ámbito del bloque
            //}
            //i++;// Fuera del ámbito del bloque

            for (int i = 0; i <= 10; i++)
            {
                int j = 0; //Dentro del ámbito del bloque
                j++;

            }
            //j++; // Fuera del ámbito del bloque

            //for (int l = 0; l <= 10; l++)
            //{
            //    l++;
            //}
            //if (1 == 1)
            //{
            //    int l = 9;
            //    l++;
            //}

            //Uso de una clase dentro del espacio de nombres
            //ClaseA objClaseA = new ClaseA();
            //Console.WriteLine(objClaseA.a);
            Console.ReadLine();
            
        }

        //2. Ambito del Método
        //public void AmbitoMetodo()
        //{
        //    int j = 0;  //declaración en el método
        //    for (int l = 0; l <= 10; l++)
        //    {
        //        j++; // Dentro del Ambito del método
        //    }

        //    j = +j; // Dentro del Ambito del método
        // }

        //public void AmbitoMetodoB()
        //{
        //    j++; // Fuera del ámbito del método
        //}

        //3. Misma variable en bloque y metodo.
        //public void AmbitoMetodoC()
        //{
        //    int j = 0;  //declaración en el método
        //    for (int l = 0; l <= 10; l++)
        //    {
        //        int j = 1; //declaración en el bloque
        //        j++; 
        //    }

        public void AmbitoMetodoD()
        {
            //4. Uso de Variable de ambito de Clase
            int j = 0;  
            for (int l = 0; l <= 10; l++)
            {
                j++; 
                j = m; // uso en el bloque
            }

            j = +j; 
            m ++; // uso en el metodo
         }
         
     }

    //Ambito de espacio de nombres
    class ClaseA
    {
        public int a = 23;
        public string b = "Hola";
    }

}
