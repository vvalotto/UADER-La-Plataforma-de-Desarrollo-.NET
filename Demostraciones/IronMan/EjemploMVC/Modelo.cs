using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMVC
{
    public delegate void ModeloHandler<IModel>(IModelo sender, ModeloEventArgs e);

    public class ModeloEventArgs: EventArgs
    {
        public int valorNuevo;
        public ModeloEventArgs(int v)
        {
            valorNuevo = v;
        }
    }

    public interface IModeloObservador
    {
        void ValorIncrementado(IModelo modelo, ModeloEventArgs e);
    }

    public interface IModelo
    {
        void Adjuntar(IModeloObservador imo);
        void Incrementar();
        void SetValor(int v);
    }

    class ModeloInc: IModelo
    {
        public event ModeloHandler<ModeloInc> cambiado;
        int valor;

        public ModeloInc()
        {
            valor = 0;
        }
        
        public void Adjuntar(IModeloObservador imo)
        {
            cambiado += new ModeloHandler<ModeloInc>(imo.ValorIncrementado);
        }

        public void Incrementar()
        {
            valor++;
            cambiado.Invoke(this, new ModeloEventArgs(valor));
        }

        public void SetValor(int v)
        {
            valor = v;
        }
    }
}
