using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWinForm.Controlador
{
    public interface IControladorObservador
    {
        void Ejecutar(string accion);
    }
}
