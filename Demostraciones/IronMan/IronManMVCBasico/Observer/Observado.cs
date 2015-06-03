using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronManMVCBasico.ObserverPattern
{
    class Observado:IObservado
    {

        private List<Observador> observadores = new List<Observador>();
        private int _int;
        private List<string> productos = new List<string>();
        private string nuevoProducto;

        public int Inventario
        {
            get { return _int; }
            set 
            {
                if (value > _int)
                    Notificar();
                _int = value;
            }
        }

        public void AgregarProducto(string producto)
        {
            productos.Add(producto);
            nuevoProducto = producto;
            Notificar();
        }


        public void Suscribir(Observador observador)
        {
            observadores.Add(observador);
        }

        public void Desuscribir(Observador observador)
        {
            observadores.Remove(observador);
        }

        public void Notificar()
        {
            observadores.ForEach(x => x.Actualizar(nuevoProducto));
        }
    }
}
