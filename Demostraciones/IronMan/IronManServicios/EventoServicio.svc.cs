using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IronMan.Dominio;
using IronMan.DTO;
using IronMan.Gestores;

namespace IronManServicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class EventoServicio : IEventoServicio
    {
        public string ObtenerNombreEvento(int id)
        {
            EventoGestor _eGestor = new EventoGestor();
            EventoDTO _eDTO = new EventoDTO();

            _eDTO = _eGestor.Obtener(id);
            return _eDTO.Nombre;

        }

        public void Guardar(Evento e)
        {
            EventoGestor _eGestor = new EventoGestor();
            EventoDTO _eDTO = new EventoDTO();

            _eDTO.Nombre = e.Nombre;
            _eDTO.Lugar = e.Lugar;
            _eDTO.Fecha = e.Fecha;
            _eDTO.Comentario = e.Comentario;

            _eGestor.Guardar(_eDTO);
        }

        public Evento Obtener(int id)
        {
 	        throw new NotImplementedException();
        }

        public List<Evento> Listar()
        {
            List<Evento> _lista = new List<Evento>();
            EventoGestor _eGestor = new EventoGestor();

            foreach (EventoDTO _eDTO in _eGestor.Listar().ToList())
            {
                _lista.Add(DTOaEvento(_eDTO));
            }
            return _lista;
        }

        private Evento DTOaEvento(EventoDTO _eDTO)
        {
            Evento _e = new Evento();
            _e.Nombre = _eDTO.Nombre;
            _e.Lugar = _eDTO.Lugar;
            _e.Fecha = _eDTO.Fecha;
            _e.Comentario = _eDTO.Comentario;

            return _e;
        }
    }
}
