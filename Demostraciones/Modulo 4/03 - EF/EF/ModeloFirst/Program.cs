using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                using (var ctx = new ModeloCampeonatoContainer())
                {
                    var _repEquipo = new Repositorio<Equipo>(ctx);

                    var _equipo = new Equipo
                    {
                        Nombre = "Boca Juniors",
                        Campeonatos = 28,
                    };

                    //ctx.Equipos.Add(_equipo);
                    _repEquipo.Guardar(_equipo);

                    _equipo = new Equipo
                    {
                        Nombre = "River Plate",
                        Campeonatos = 33,
                    };
                    //ctx.Equipos.Add(_equipo);
                    _repEquipo.Guardar(_equipo);

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ":" + ex.InnerException);
            }
          


            using (var ctx = new ModeloCampeonatoContainer())
            {
                //var _equipos = from e in ctx.Equipos
                //               select e;
                var _repEquipo = new Repositorio<Equipo>(ctx);
                var _equipos = _repEquipo.GetTodos();

                foreach (Equipo e in _equipos)
                {
                    Console.WriteLine(">" + e.Nombre);
                }

            }

            using (var ctx = new ModeloCampeonatoContainer())
            {
                //var _equipos = from e in ctx.Equipos
                //               where e.Nombre == "Boca Juniors"
                //               select e;
                //var _equipo = _equipos.SingleOrDefault();

                var _repEquipo = new Repositorio<Equipo>(ctx);
                var _equipo = _repEquipo.GetPorId(13);

                _equipo.Campeonatos = 30;


                ctx.SaveChanges();

            }

            using (var ctx = new ModeloCampeonatoContainer())
            {
                var _equipos = from e in ctx.Equipos
                               select e;
                foreach (Equipo e in _equipos)
                {
                    Console.WriteLine(">" + e.Campeonatos);
                }

            }
            Console.WriteLine("Hecho");
            Console.ReadKey();
        }
    }
}
