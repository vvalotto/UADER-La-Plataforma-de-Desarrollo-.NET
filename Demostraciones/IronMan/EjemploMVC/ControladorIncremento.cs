using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVC
{
    public class ControladorIncremento: IControlador
    {
        IVista _vista;
        IModelo _modelo;

        public ControladorIncremento(IVista vista, IModelo modelo)
        {
            _vista = vista;
            _modelo = modelo;
            vista.SetControlador(this);
            modelo.Adjuntar((IModeloObservador)_vista);
            _vista.cambiada += new VistaHandler<IVista>(this.vista_cambiada);
        }

        public void vista_cambiada(IVista vista, VistaEventArgs e)
        {
            _modelo.SetValor(e.valor);
        }

        public void IncrementarValor()
        {
            _modelo.Incrementar();
        }
    }
}
