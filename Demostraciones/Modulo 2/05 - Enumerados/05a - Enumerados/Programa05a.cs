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
            
            // 1. Declaracion de variables de enumerados
            Colores micolora = Colores.Verde;
            Colores micolorb = Colores.Rojo;
            Console.WriteLine(micolora);
            Console.WriteLine((int)micolorb);
           

            // 2. Operaciones con Enumerados
            Colores MiColorA = Colores.Verde;
            Colores MiColorB = Colores.Azul;
            Colores MiColorBitWise = MiColorA | MiColorB;
            Console.WriteLine("Operacion OR: {0} - {1}", MiColorBitWise, (sbyte)MiColorBitWise);
            Colores MiColorBitWiseB = MiColorA & MiColorB;
            Console.WriteLine("Operacion AND: {0} - {1}", MiColorBitWiseB, (sbyte)MiColorBitWiseB);
            Console.ReadLine();



        }
    }
}
