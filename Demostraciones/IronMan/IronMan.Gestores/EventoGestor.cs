using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.DTO;
using IronMan.Repositorio;
using IronMan.AccesoDatos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.Dominio.Modelos;

namespace IronMan.Gestores
{
    public class EventoGestor: IGestor<EventoDTO>,IDisposable
    {
        EventoRepositorio _repositorio;
        IronManContext _ctx;
        Evento _evento;

        public EventoGestor()
        {
            try
            {
                var ctx = new IronManContext();
                _ctx = ctx;
                _repositorio = new EventoRepositorio(_ctx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public void Guardar(EventoDTO e)
        {
             
            try
            {
                if (e.Id > 0)
                {
                    Evento _eMod = DTOaModelo(e);
                    _evento = _repositorio.GetPorId(e.Id);
                    this.ActualizaEvento(_eMod, _evento);
                }
                else
                {
                    _evento = DTOaModelo(e);
                }
                _repositorio.Guardar(_evento, _evento.Id);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }

        }

        public void Habilitar(EventoDTO e)
        {
            try
            {
                _evento = _repositorio.GetPorId(e.Id);
                _evento.EstaHabilitado = e.EstaHabilitado;
                _repositorio.Guardar(_evento, _evento.Id);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }

        }

        public void Deshabilitar(EventoDTO e)
        {
            try
            {
                _evento = _repositorio.GetPorId(e.Id);
                Console.WriteLine(_ctx.Entry(_evento).State.ToString());
                _evento.EstaHabilitado = e.EstaHabilitado;
                _repositorio.Guardar(_evento, _evento.Id);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public EventoDTO Obtener(int id)
        {
            EventoDTO _eDTO = new EventoDTO();
            try
            {
                _eDTO = ModeloaDTO(_repositorio.GetPorId(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }
            return _eDTO;
        }

        public IList<EventoDTO> Listar()
        {
            IList<EventoDTO> _eDTOLista= new List<EventoDTO>();

            try
            {
                IQueryable<Evento> _eLista = _repositorio.GetTodos();
 
                foreach (Evento e in _eLista)
                {
                    _eDTOLista.Add(ModeloaDTO(e));
                };
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }
            return _eDTOLista;

        }

        public bool Validar(EventoDTO _eDTO)
        {
 	        throw new NotImplementedException();
        }

        private Evento DTOaModelo(EventoDTO _eDTO)
        {
            Evento _evento = new Evento();
            _evento.Id = _eDTO.Id;
            _evento.Nombre = _eDTO.Nombre;
            _evento.Lugar = _eDTO.Lugar;
            _evento.Fecha = _eDTO.Fecha;
            _evento.Comentario = _eDTO.Comentario;
            _evento.EstaHabilitado = _eDTO.EstaHabilitado;

            return _evento;
        }

        private EventoDTO ModeloaDTO(Evento _e)
        {
            var _eDTO = new EventoDTO();
            _eDTO.Id = _e.Id;
            _eDTO.Nombre = _e.Nombre;
            _eDTO.Lugar = _e.Lugar;
            _eDTO.Fecha = _e.Fecha;
            _eDTO.Comentario = _e.Comentario;
            _eDTO.EstaHabilitado = _e.EstaHabilitado;
            _eDTO.Pruebas = _e.Pruebas;

            return _eDTO;
        }

        private void ActualizaEvento(Evento _eMod, Evento _evento)
        {
           
            _evento.Nombre = _eMod.Nombre;
            _evento.Lugar = _eMod.Lugar;
            _evento.Fecha = _eMod.Fecha;
            _evento.Comentario = _eMod.Comentario;
            _evento.EstaHabilitado = _eMod.EstaHabilitado;
        }
        public void Dispose()
        { 
            GC.SuppressFinalize(this); 
        }
    }
}
