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
    public class PruebaGestor : IGestor<PruebaDTO>, IDisposable
    {
        public readonly PruebaRepositorio _repositorio;
        IronManContext _ctx;
        Prueba _prueba;

        public PruebaGestor()
        {
            try
            {
                var ctx = new IronManContext();
                _ctx = ctx;
                _repositorio = new PruebaRepositorio(_ctx);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public void Guardar(PruebaDTO p)
        {
            try
            {
                if (p.Id > 0)
                {
                    Prueba _p;
                    _prueba = _repositorio.GetPorId(p.Id);
                    _p = DTOaModelo(p);
                    _prueba = _p;
                }
                _prueba = DTOaModelo(p);
                _repositorio.Guardar(_prueba, _prueba.Id);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public void Habilitar(PruebaDTO entidad)
        {
            throw new NotImplementedException(); ;
        }

        public void Deshabilitar(PruebaDTO entidad)
        {
            throw new NotImplementedException();
        }

        public PruebaDTO Obtener(int id)
        {
            var _p = _repositorio.GetPorId(id);
            return ModeloaDTO(_p);
        }

        public IList<PruebaDTO> Listar()
        {
            IQueryable<Prueba> _pLista = _repositorio.GetTodos();
            IList<PruebaDTO> _pDTOLista = new List<PruebaDTO>();
            
            foreach (Prueba p in _pLista)
            {
                _pDTOLista.Add(ModeloaDTO(p));

            }
            return _pDTOLista;
        }

        public bool Validar(PruebaDTO entidad)
        {
            throw new NotImplementedException();
        }

        private Prueba DTOaModelo(PruebaDTO _pDTO)
        {
            var _prueba = new Prueba();

            _prueba.Tipo = _pDTO.Tipo;
            _prueba.Distancia = _pDTO.Distancia;
            _prueba.Evento_Id = _pDTO.Evento_Id;
            _prueba.EstaHabilitado = _pDTO.EstaHabilitado;

            return _prueba;
        }

        private PruebaDTO ModeloaDTO(Prueba _p)
        {
            var _pDTO = new PruebaDTO();
            _pDTO.Tipo = _p.Tipo;
            _pDTO.Distancia = _p.Distancia;
            _pDTO.Evento_Id = _p.Evento_Id;
            _pDTO.EstaHabilitado = _p.EstaHabilitado;

            return _pDTO;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
