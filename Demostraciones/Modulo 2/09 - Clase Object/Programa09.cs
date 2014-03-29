using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
     class UnaClase
        {
            public int i;
            public string s;

            public UnaClase (int pi, string ps)
            {
                i = pi;
                s = ps;
            }
        }

    class Programa09:Programa
    {


        internal override void Ejecutar()
        {
            //Metodo Estático Equals - Caso 1 - Compara dos tipos enteros
            int n1 = 2;
            int n2 = 3;
            bool result1 = object.Equals(n1, n2);
            Console.WriteLine("Resultado: " + result1.ToString());

            //Metodo Estático Equals - Caso 2 - Compara dos tipos string
            string s1 = "test";
            string s2 = "test";
            bool result2 = object.Equals(s1, s2);
            Console.WriteLine("Resultado: " + result2.ToString());

            //Metodo Estático Equals - Caso 3 - Compara dos tipos definidos por el usuario (Clases)
            object obj1 = new UnaClase(1, "Test1");
            object obj2 = new UnaClase(1, "Test1");
            bool result3 = object.Equals(obj1, obj2);
            Console.WriteLine("Resultado: " + result3.ToString());

            //Metodo Equals - de Object
            string s3 = "test";
            string s4 = "test";
            bool result4 = s3.Equals(s4);
            Console.WriteLine("resultado: " + result4.ToString());

            object obj4 = new UnaClase(1, "Test1");
            object obj5 = new UnaClase(1, "Test1");
            object obj6 = obj4;
            bool result5 = obj4.Equals(obj5);
            bool result6 = obj4.Equals(obj6);
            Console.WriteLine("Resultado2: " + result5.ToString());
            Console.WriteLine("Resultado3: " + result6.ToString());

            //Metodo HashCode
            object obj7 = 4;
            object obj8 = "Test";
            object obj9 = new UnaClase(1, "Test1");

            int resultA = obj7.GetHashCode();
            int resultB = obj8.GetHashCode();
            int resultC = obj9.GetHashCode();
            Console.WriteLine("Resultado: " + resultA.ToString());
            Console.WriteLine("Resultado: " + resultB.ToString());
            Console.WriteLine("Resultado: " + resultC.ToString());

            //GetType
            object obj10 = 4;
            object obj11 = "Test";
            object obj12 = new UnaClase(1, "Test1");

            string type1 = obj10.GetType().ToString();
            string type2 = obj11.GetType().ToString();
            string type3 = obj12.GetType().ToString();
            Console.WriteLine("Resultado: " + type1.ToString());
            Console.WriteLine("Resultado: " + type2.ToString());
            Console.WriteLine("Resultado: " + type3.ToString());


            Console.ReadKey();

        }
    }
}
