using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronManMVCBasico.ObserverPattern
{
    interface IObservado
    {
        void Suscribir(Observador observador);
        void Desuscribir(Observador observador);
        void Notificar();
    }
}
