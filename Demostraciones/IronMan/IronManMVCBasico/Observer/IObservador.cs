using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronManMVCBasico.ObserverPattern
{
    interface IObservador
    {
        void Actualizar(string producto);
    }
}
