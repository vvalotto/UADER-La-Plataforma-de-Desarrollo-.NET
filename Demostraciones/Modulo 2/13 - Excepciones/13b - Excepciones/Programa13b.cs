using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa13b:Programa
    {
        internal override void Ejecutar()
        {
            //1. Declaracion de lo miembros
            int i;
            int j ;
            int res = 0;

            //2.tratamiento de error
            try 
            {
                Console.Write("Un numero:");
                i = Convert.ToInt32 (Console.ReadLine());
                Console.Write("Otro numero:");
                j = Convert.ToInt32 (Console.ReadLine());
                res = i/j;
                Console.WriteLine(res.ToString());
            }

            //5. Atrapa excepciones particulares
            catch (FormatException)
            {
                Console.WriteLine("El ingreso de datos no está en el formato correcto");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Division por 0. Error");
            }

            //4. Atrapa al excepcion
            catch (Exception ex)
            {
	            Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Resultado: {0}", res);
            Console.ReadKey();


        }
    }
}
