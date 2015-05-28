using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronManMVCBasico.ObserverPattern
{
    class Subject:ISubject
    {

        private List<Observador> observadores = new List<Observador>();
        private int _int;

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
            observadores.ForEach(x => x.Actualizar());
        }
    }
}
