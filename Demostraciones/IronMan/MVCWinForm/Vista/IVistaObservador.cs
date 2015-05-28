using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinForm.Vista
{
    public interface IVistaObservador
    {
        void Actualizar(string tipoArctualizacion);
    }
}
