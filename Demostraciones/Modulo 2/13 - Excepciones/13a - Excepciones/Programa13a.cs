using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa13a:Programa
    {
        internal override void Ejecutar()
        {
            int i = 10;
            int j = 0;
            int resultado;

            try 
            {
                    if (j == 0)
                    {
	                    Console.WriteLine("El Valor introducido no puede ser 0");
	                    Console.ReadLine();
	                    return;
                    }
                    resultado = i/j;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadLine();


        }
    }
}
