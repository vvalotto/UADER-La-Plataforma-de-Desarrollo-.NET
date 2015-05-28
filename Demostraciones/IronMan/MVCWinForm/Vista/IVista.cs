using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCWinForm.Controlador;

namespace MVCWinForm.Vista
{
    public interface IVista
    {
        void AdjuntarControlador(IControladorObservador controlador);
        void RemoverControlador(IControladorObservador controlador);
        void Notificar(string accion);
    }
}
