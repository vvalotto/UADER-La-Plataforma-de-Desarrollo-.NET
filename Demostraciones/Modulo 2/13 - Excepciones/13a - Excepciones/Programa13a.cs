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
            //1. Declaracion de los miembros
            int i = 10;
            int j = 0;
            int resultado;

            //2. Manejo de Excepciones 
            #region Excepcion
            try 
            {
                    //4. Control programatico
                    //if (j == 0)
                    //{
                    //    Console.WriteLine("El Valor introducido no puede ser 0");
                    //    Console.ReadKey();
                    //    return;
                    //}
                    resultado = i/j;
            }

            catch (Exception ex)
            {
                //2. Atrapar la excepcion
                Console.WriteLine("Error!>:");
                Console.WriteLine(ex.Message + "\n");
                //3. Mayor Informacion de la excepcion
                Console.WriteLine("Traza:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("En que método:");
                Console.WriteLine(ex.TargetSite);

            }
            #endregion 

            Console.ReadKey();


        }
    }
}
