using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVC
{
    
    public delegate void VistaHandler<IVista>(IVista sender, VistaEventArgs e);

    public class VistaEventArgs:EventArgs
    {
        public int valor;
        public VistaEventArgs(int v)
        {
            valor = v;
        }
    }
    
    public interface IVista
    {
        event VistaHandler<IVista> cambiada;
        void SetControlador(IControlador controlador);
    }
}
