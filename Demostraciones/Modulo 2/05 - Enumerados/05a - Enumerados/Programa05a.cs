using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    //1.Definir la lista de enumerados
    //enum Colores : byte
    //{
    //    Rojo,
    //    Verde,
    //    Azul
    //}

    //2. Nueva definición 
    [Flags()]
    enum Colores : sbyte
    {
        Rojo = 0,
        Verde = 1,
        Azul = 2,
        Amarillo = 3
    }

    class Programa05a:Programa
    {
        internal override void Ejecutar()
        {
            Modulo2.MostrarTituloDemo("\nInicio Tipo Enumeracion A\n");

            #region Incio del Codigo Demo

            #endregion

            Console.ReadKey();

        }
    }
}
