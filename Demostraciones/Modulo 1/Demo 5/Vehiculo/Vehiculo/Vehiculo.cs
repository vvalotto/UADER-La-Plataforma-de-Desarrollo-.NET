using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploIntegracion
{
    public interface IManejo
    {
        void DoblarIzquierda();
        void DoblarDerecha();
    }

    public class Vehiculo : IManejo
    {

        public virtual void DoblarIzquierda()
        {
            Console.WriteLine("El vehiculo dobla a la izquierda");
        }

        public virtual void DoblarDerecha()
        {
            Console.WriteLine("El vehiculo dobla a la derecha");
        }

        public virtual void AplicarFrenos()
        {
        }
    }
}
