using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_3
{
    internal class Programa02c:Programa
    {
        internal override void Ejecutar()
        {
            Documento miDocumento = new Documento("Texto1", @"c:\Temp\");
            miDocumento.IngresarTexto();
            miDocumento.GuardarTexto();
            miDocumento.MostrarTexto();
            Console.ReadKey();

            Documento otroDoc = new Documento("Texto1", @"c:\Temp\");
            otroDoc.RecuperarTexto();
            otroDoc.MostrarTexto();

        }
    }

}
