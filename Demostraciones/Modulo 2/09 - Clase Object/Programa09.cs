using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
     class Person
        {
            public int i;
            public string s;

            public Person (int pi, string ps)
            {
                i = pi;
                s = ps;
            }
        }

    class Programa09:Programa
    {


        internal override void Ejecutar()
        {
            //Metodo Estático Equals
            //int n1 = 2;
            //int n2 = 3;
            //bool result1 = object.Equals(n1, n2);
            //Console.WriteLine("Resultado: " + result1.ToString());

            //string s1 = "test";
            //string s2 = "test";
            //bool result2 = object.Equals(s1, s2);
            //Console.WriteLine("Resultado: " + result2.ToString());

            //object obj1 = new Person(1, "Test1");
            //object obj2 = new Person(1, "Test1");
            //bool result3 = object.Equals(obj1, obj2);
            //Console.WriteLine("Resultado: " + result3.ToString());

            //Metodo Equals
            //string s1 = "Test";
            //string s2 = "Test";
            //bool result1 = s1.Equals(s2);
            //Console.WriteLine("Resultado: " + result1.ToString());

            //object obj4 = new Person(1, "Test1");
            //object obj5 = new Person(1, "Test1");
            //object obj6 = obj4;
            //bool result2 = obj4.Equals(obj5);
            //bool result3 = obj4.Equals(obj6);
            //Console.WriteLine("Resultado2: " + result2.ToString());
            //Console.WriteLine("Resultado3: " + result3.ToString());

            //Metodo HashCode
            //object obj7 = 4;
            //object obj8 = "Test";
            //object obj9 = new Person(1, "Test1");

            //int resultA = obj7.GetHashCode();
            //int resultB = obj8.GetHashCode();
            //int resultC = obj9.GetHashCode();
            //Console.WriteLine("Resultado: " + resultA.ToString());
            //Console.WriteLine("Resultado: " + resultB.ToString());
            //Console.WriteLine("Resultado: " + resultC.ToString());

            //GetType
            //object obj1 = 4;
            //object obj2 = "Test";
            //object obj3 = new Person(1, "Test1");

            //string type1 = obj1.GetType().ToString();
            //string type2 = obj2.GetType().ToString();
            //string type3 = obj3.GetType().ToString();
            //Console.WriteLine("Resultado: " + type1.ToString());
            //Console.WriteLine("Resultado: " + type2.ToString());
            //Console.WriteLine("Resultado: " + type3.ToString());


            Console.ReadLine();

        }
    }
}
