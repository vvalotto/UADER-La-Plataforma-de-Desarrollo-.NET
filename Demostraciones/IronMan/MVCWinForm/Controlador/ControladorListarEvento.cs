using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCWinForm.Modelo;
using MVCWinForm.Vista;
using IronMan.Gestores;
using IronMan.DTO;
using IronMan.Dominio;


namespace MVCWinForm.Controlador
{
    public class ControladorListarEvento: IControladorObservador
    {
        IVistaListarEvento _vista;
        ListaEventoObservado _modelo;

        public ControladorListarEvento(IVistaListarEvento v, ListaEventoObservado o)
        {
            _vista = v;
            _modelo = o;
        }

        public void AccionListarEventos()
        {
            IList<EventoDTO> _lista = _modelo.ListarEventos();
            Console.WriteLine(_lista.Count);
            _vista.ListarEventos(_lista);

        }

        public void AccionMostrarEvento(int id)
        {
            EventoDTO evento = _modelo.Obtener(id);
            _vista.MostrarEventos(evento);
        }

        public void Ejecutar(string accion)
        {
            if (accion == "listar")
            {
                AccionListarEventos();
            }
        }
    }
}
