using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_2
{
    class Programa03:Programa
    {
        internal override void Ejecutar()
        {
            
            //Declaración e instanciacion de diferentes tipos de datos
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            Int64 e = 0;
            string s = "";
            Exception ex = new Exception();

            //Se compone un arreglo de objetos con las instanciaciones
            Object[] types = { a, b, c, d, e, s, ex };

            //Obtener el tipo de datos definido para cada instancia
            foreach (object o in types)
            {
                string type;
                if (o.GetType().IsValueType)
                    type = "Tipo Valor";
                else
                    type = "Tipo Referencia";
                Console.WriteLine("{0}: {1}", o.GetType(), type);
            }
            Console.ReadKey();
        }
    }
}
