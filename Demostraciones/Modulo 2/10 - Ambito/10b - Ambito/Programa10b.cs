using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo_2
{
    class Programa10b:Programa
    {
        internal override void Ejecutar()
        {
            Humano p = new Humano();
            
        }
    }

    public class Humano
    {
        protected string nombre = string.Empty;
    }

    public class cliente : Humano
    {
        public cliente()
        {
            this.nombre = "Sin nombre";
        }
    }
}
