using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCWinForm.Vista;

namespace MVCWinForm.Modelo
{
    public interface IModeloObservado
    {
        void AgregarObservador(IVistaObservador vista);
        void RetirarObservador(IVistaObservador vista);
        void Notificar();
    }
}
