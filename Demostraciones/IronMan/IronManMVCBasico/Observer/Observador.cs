﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronManMVCBasico.ObserverPattern
{
    class Observador:IObservador
    {
        public string NombreObservador { get; private set; }
        public Observador(string nombre)
        {
            this.NombreObservador = nombre;
        }

        public void Actualizar(string producto)
        {
            Console.WriteLine("{0}: Un nuevo producto se ha incoporado es: {1}.", this.NombreObservador, producto);
        }
    }
}
