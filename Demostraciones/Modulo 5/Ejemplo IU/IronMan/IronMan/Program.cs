using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.Dominio.Modelos;
using IronMan.Dominio.AccesoDatos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.Gestores;
using IronMan.DTO;
using IronMan.Repositorio;


namespace IronMan
{
    class Program
    {
        static void Main(string[] args)
        {

            Program programa = new Program();
            
            try
            {
                using (EventoGestor _eGestor = new EventoGestor())
                {

                    Console.WriteLine("Listar Eventos");
                    #region Listar Eventos
                    IList<EventoDTO> _eLista = _eGestor.Listar();
                    foreach (Evento e in _eLista)
                    {
                        Console.WriteLine(e.Id);
                        Console.WriteLine(e.Nombre);
                        Console.WriteLine(e.Lugar);
                        Console.WriteLine(e.Fecha.ToString());
                        Console.WriteLine(e.Comentario);
                        Console.WriteLine(e.EstaHabilitado);
                        Console.WriteLine("********");

                        foreach (Prueba p in e.Pruebas)
                        {
                            Console.WriteLine("    >" + p.Tipo);
                            Console.WriteLine("    >" + p.Distancia);
                            Console.WriteLine("    >" + p.Evento_Id);
                            Console.WriteLine("    >" + p.Evento);
                            Console.WriteLine("    >" + p.EstaHabilitado);
                            Console.WriteLine("------------------------");
                        }
                    }
                    Console.ReadKey();
                    #endregion

                    programa.MostarEvento(_eGestor, 3);

                    #region Agregar un evento
                    //Console.Clear();
                    //Console.WriteLine("Agregar un Evento");

                    //var _eventoDTO = new EventoDTO();
                    //_eventoDTO.Nombre = "Verano 4444";
                    //_eventoDTO.Lugar = "Colon 4444";
                    //_eventoDTO.Fecha = new DateTime(2014, 5, 10);
                    //_eventoDTO.Comentario = "Sol 4444";
                    //_eventoDTO.EstaHabilitado = true;
                    //_eGestor.Guardar(_eventoDTO);
                    //Console.ReadKey();
                    #endregion

                    #region Modificar un evento
                    Console.Clear();
                    Console.WriteLine("Modificar un Evento");

                    var _eDTOMod = _eGestor.Obtener(7); ;
                    _eDTOMod.Nombre = _eDTOMod.Nombre + "*!!!!";
                    _eDTOMod.Lugar = _eDTOMod.Lugar + "AAAAAAA";
                    _eDTOMod.Comentario = _eDTOMod.Comentario + "$$$$$";
                    _eGestor.Guardar(_eDTOMod);
                    programa.MostarEvento(_eGestor, 7
                        );
                    Console.ReadKey();
                    #endregion

                    #region Deshabilitar un evento
                    //Console.Clear();
                    //Console.WriteLine("Deshabilitar un Evento");

                    //var _eDTOMod = _eGestor.Obtener(11);
                    //_eDTOMod.EstaHabilitado = false;
                    //_eGestor.Deshabilitar(_eDTOMod);
                    //programa.MostarEvento(_eGestor, 11);
                    //Console.ReadKey();
                    #endregion
                }

               //using (var ctx = new IronManContext())
               //{
               //     PruebaRepositorio _prueba = new PruebaRepositorio(ctx);
               //     IQueryable<Prueba> _pLista = _prueba.GetTodos();
               //}

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

            Console.ReadKey();
        }

        private void MostarEvento(EventoGestor _eGestor, int Id)
        {
            Console.Clear();
            Console.WriteLine("Obtener un Evento");
            #region Obtener un evento
            var _e = _eGestor.Obtener(Id);
            Console.WriteLine(_e.Id);
            Console.WriteLine(_e.Nombre);
            Console.WriteLine(_e.Lugar);
            Console.WriteLine(_e.Fecha.ToString());
            Console.WriteLine(_e.Comentario);
            Console.WriteLine(_e.EstaHabilitado);
            Console.WriteLine("********");

            foreach (Prueba p in _e.Pruebas)
            {
                Console.WriteLine("    >" + p.Tipo);
                Console.WriteLine("    >" + p.Distancia);
                Console.WriteLine("    >" + p.Evento_Id);
                Console.WriteLine("    >" + p.Evento);
                Console.WriteLine("    >" + p.EstaHabilitado);
                Console.WriteLine("------------------------");
            }
            #endregion
            Console.ReadKey();
        }

        public void InicializarEventos()
        {
            //Llenado Inicial de Eventos
            try
            {
                using (var ctx = new IronManContext())
                {
                    
                    var _evento1 = new Evento();
                    _evento1.Nombre = "Por el Rio";
                    _evento1.Lugar = "Parana";
                    _evento1.Fecha = new DateTime(2014, 5, 10);
                    _evento1.Comentario = "Sin";
                    _evento1.EstaHabilitado = true;

                    ctx.Eventos.Add(_evento1);

                    var _evento2 = new Evento();
                    _evento2.Nombre = "Corremos Todo";
                    _evento2.Lugar = "Santa Fe";
                    _evento2.Fecha = new DateTime(2014, 7, 23);
                    _evento2.Comentario = "Sin";
                    _evento2.EstaHabilitado = true;

                    ctx.Eventos.Add(_evento2);

                    var _evento3 = new Evento();
                    _evento3.Nombre = "XMV";
                    _evento3.Lugar = "Rosario";
                    _evento3.Fecha = new DateTime(2014, 6, 25);
                    _evento3.Comentario = "Sin";
                    _evento3.EstaHabilitado = true;

                    ctx.Eventos.Add(_evento3);

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

        }

        public void InicializarPruebas()
        {
            //Llenado Inicial de Eventos
            try
            {
                using (var ctx = new IronManContext())
                {

                    var _evento = from e in ctx.Eventos
                                  where e.Nombre == "Por el Rio"
                                  select e;

                    var ev = _evento.SingleOrDefault();

                    if (ev != null)
                    {
                        var _prueba1 = new Prueba();
                        _prueba1.Tipo = "Pedestre";
                        _prueba1.Distancia = "5 K";
                        _prueba1.Evento_Id = ev.Id;
                        _prueba1.EstaHabilitado = true;
                        ctx.Pruebas.Add(_prueba1);
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

        }
    }
}
