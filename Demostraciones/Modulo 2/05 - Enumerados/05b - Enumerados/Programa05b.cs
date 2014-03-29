using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{

    class Programa05b:Programa
    {

        internal override void Ejecutar()
        {
            //3. Asignaciones de valores no contemplados en la lista de enumerados
            Colores MiColorA = Colores.Verde;
            Colores MiColorB = Colores.Azul;
            Colores MiColorC = (Colores)5;
            Console.WriteLine(MiColorC);

            //4. Evaluación de contenido de la variable enumerada
            Programa p = new Programa();
            p.Trabajar(MiColorC);
            Console.ReadKey();
        }

        class Programa
        {
            public void Trabajar(Colores color)
            {
                if (Enum.IsDefined(typeof(Colores), color)) //
                    Console.WriteLine(color);
                else
                    Console.WriteLine("Tipo no definido, ERROR!");
            }
        }

    }
}
